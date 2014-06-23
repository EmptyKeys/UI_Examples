//-----------------------------------------------------------------------------
// Synapse Gaming - SunBurn Starter Kit
// Copyright © Synapse Gaming 2012
//-----------------------------------------------------------------------------

#region Using Statements
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SynapseGaming.SunBurn.Framework.Content;
using SynapseGaming.SunBurn.Framework.Core;
using SynapseGaming.SunBurn.Framework.Graphics;
using SynapseGaming.SunBurn.Framework.Input;
using SynapseGaming.SunBurn.Framework.Models;
using SynapseGaming.SunBurn.Framework.Primitives;
using SynapseGaming.SunBurn.Engine.Core;
using SynapseGaming.SunBurn.Engine.Editor;
using SynapseGaming.SunBurn.Engine.Rendering;
#endregion


namespace GameLibrary.Input
{
    /// <summary>
    /// Base class for converting player input to movement.
    /// </summary>
    public abstract class BaseInputSource
    {
        public Vector3 MoveAmount { get { return _MoveAmount; } }
        public float TurnAmount { get { return _TurnAmount; } }
        public float LookUpDownAmount { get { return _LookUpDownAmount; } }
        public bool Jump { get { return _Jump; } }
        public bool Crouch { get { return _Crouch; } }

        protected Vector3 _MoveAmount;
        protected float _TurnAmount;
        protected float _LookUpDownAmount;
        protected bool _Jump;
        protected bool _Crouch;

        protected abstract void CalculateMovement();

        public void Update()
        {
            // Zero out values for this update.
            _MoveAmount = Vector3.Zero;
            _TurnAmount = 0.0f;
            _LookUpDownAmount = 0.0f;
            _Jump = false;
            _Crouch = false;

            CalculateMovement();
        }
    }

    /// <summary>
    /// Converts gamepad input to movement.
    /// </summary>
    public class GamepadInputSource : BaseInputSource
    {
        private int _PlayerNumber;

        public GamepadInputSource(int playernumber)
        {
            _PlayerNumber = playernumber;
        }

        protected override void CalculateMovement()
        {
            GamePadState gamepad = Platform.Instance.InputDevice.GamePadStates.GetByPlayerNumber(_PlayerNumber);

            if(gamepad == null)
                return ;

            _MoveAmount.X = gamepad.LeftThumbStick.X;
            _MoveAmount.Y = gamepad.LeftThumbStick.Y;
            _TurnAmount = gamepad.RightThumbStick.X;
            _LookUpDownAmount = gamepad.RightThumbStick.Y;

            _Jump = gamepad.AButtonPressed;
            _Crouch = gamepad.BButtonPressed;
        }
    }

    /// <summary>
    /// Converts keyboard input to movement.
    /// </summary>
    public class KeyboardInputSource : BaseInputSource
    {
        protected override void CalculateMovement()
        {
            KeyboardState keyboard = Platform.Instance.InputDevice.KeyboardState;

            // Forward
            if (keyboard.KeyPressed(Keys.W) || keyboard.KeyPressed(Keys.NumPad8) || keyboard.KeyPressed(Keys.Up))
                _MoveAmount.Y += 1.0f;
            // Backward
            if (keyboard.KeyPressed(Keys.S) || keyboard.KeyPressed(Keys.NumPad2) || keyboard.KeyPressed(Keys.Down))
                _MoveAmount.Y -= 1.0f;

            // Strafe left
            if (keyboard.KeyPressed(Keys.A) || keyboard.KeyPressed(Keys.NumPad4) || keyboard.KeyPressed(Keys.Left))
                _MoveAmount.X -= 1.0f;
            // Strafe right
            if (keyboard.KeyPressed(Keys.D) || keyboard.KeyPressed(Keys.NumPad6) || keyboard.KeyPressed(Keys.Right))
                _MoveAmount.X += 1.0f;

            // Turn left
            if (keyboard.KeyPressed(Keys.Q) || keyboard.KeyPressed(Keys.NumPad7))
                _TurnAmount -= 1.0f;
            // Turn right
            if (keyboard.KeyPressed(Keys.E) || keyboard.KeyPressed(Keys.NumPad9))
                _TurnAmount += 1.0f;

            // Look up
            if (keyboard.KeyPressed(Keys.PageUp))
                _LookUpDownAmount += 1.0f;
            // Look down
            if (keyboard.KeyPressed(Keys.PageDown))
                _LookUpDownAmount -= 1.0f;

            _Jump = keyboard.KeyPressed(Keys.Space);
            _Crouch = keyboard.KeyPressed(Keys.C);
        }
    }

    /// <summary>
    /// Converts mouse input to movement.
    /// </summary>
    public class MouseInputSource : BaseInputSource
    {
        private bool _FirstMouseSample = true;

        protected override void CalculateMovement()
        {
            MouseState mouse = Platform.Instance.InputDevice.MouseState;

            // Avoid locking the mouse when the editor is open.
            if(SunBurnEditorClient.Instance.EditorOpen)
                return;

            if (!_FirstMouseSample)
            {
                // Turn left / right
                _TurnAmount = (mouse.NormalizedX - 0.5f) * 40.0f;
                // Look up / down
                _LookUpDownAmount = (mouse.NormalizedY - 0.5f) * -20.0f;

                // Clamp the movement range.
                _TurnAmount = MathHelper.Clamp(_TurnAmount, -2.0f, 2.0f);
                _LookUpDownAmount = MathHelper.Clamp(_LookUpDownAmount, -1.0f, 1.0f);
            }

            // Lock the mouse to the screen center.
            mouse.SetPositionNormalized(0.5f, 0.5f);

            _FirstMouseSample = false;
        }
    }

    /// <summary>
    /// Converts touch input to movement.
    /// </summary>
    public class TouchInputSource : BaseInputSource
    {
        enum TouchSourceMovementType
        {
            Move,
            Look,
            Count
        }

        private Nullable<TouchLocation>[] _CurrentTouchSource = new Nullable<TouchLocation>[(int)TouchSourceMovementType.Count];
        private Vector2[] _CurrentTouchSourceMovement = new Vector2[(int)TouchSourceMovementType.Count];

        protected override void CalculateMovement()
        {
            TouchState touch = Platform.Instance.InputDevice.TouchState;
            Nullable<TouchLocation> move_currentlocation = _CurrentTouchSource[(int)TouchSourceMovementType.Move];
            Nullable<TouchLocation> look_currentlocation = _CurrentTouchSource[(int)TouchSourceMovementType.Look];

            // Find the initial move touch source?
            if (!move_currentlocation.HasValue)
            {
                _CurrentTouchSource[(int)TouchSourceMovementType.Move] = FindInitialTouchSource(TouchSourceMovementType.Move, touch);
                move_currentlocation = _CurrentTouchSource[(int)TouchSourceMovementType.Move];
            }

            // Find the initial look touch source?
            if (!look_currentlocation.HasValue)
            {
                _CurrentTouchSource[(int)TouchSourceMovementType.Look] = FindInitialTouchSource(TouchSourceMovementType.Look, touch);
                look_currentlocation = _CurrentTouchSource[(int)TouchSourceMovementType.Look];
            }

            // Determine the movement amount.
            if (move_currentlocation.HasValue)
            {
                // Find the next location.
                Nullable<TouchLocation> move_nextlocation = GetTouchSourceNextLocation(move_currentlocation, touch);
                if (move_nextlocation.HasValue)
                {
                    if (move_nextlocation.Value.State == TouchLocationState.Released)
                        _CurrentTouchSource[(int)TouchSourceMovementType.Move] = null;
                    else
                    {
                        // Determine the movement of the source.
                        _CurrentTouchSourceMovement[(int)TouchSourceMovementType.Move].X = (move_nextlocation.Value.NormalizedX - move_currentlocation.Value.NormalizedX) * 40.0f;
                        _CurrentTouchSourceMovement[(int)TouchSourceMovementType.Move].Y = (move_nextlocation.Value.NormalizedY - move_currentlocation.Value.NormalizedY) * -20.0f;
                    }
                }

                // Apply the source movement as input.
                _MoveAmount = new Vector3(_CurrentTouchSourceMovement[(int)TouchSourceMovementType.Move], 0.0f);
            }

            // Determine the look amount.
            if (look_currentlocation.HasValue)
            {
                // Find the next location.
                Nullable<TouchLocation> look_nextlocation = GetTouchSourceNextLocation(look_currentlocation, touch);
                if (look_nextlocation.HasValue)
                {
                    if (look_nextlocation.Value.State == TouchLocationState.Released)
                        _CurrentTouchSource[(int)TouchSourceMovementType.Look] = null;
                    else
                    {
                        // Determine the movement of the source.
                        _CurrentTouchSourceMovement[(int)TouchSourceMovementType.Look].X = (look_nextlocation.Value.NormalizedX - look_currentlocation.Value.NormalizedX) * 10.0f;
                        _CurrentTouchSourceMovement[(int)TouchSourceMovementType.Look].Y = (look_nextlocation.Value.NormalizedY - look_currentlocation.Value.NormalizedY) * -5.0f;
                    }
                }

                // Apply the source movement as input.
                _TurnAmount = _CurrentTouchSourceMovement[(int)TouchSourceMovementType.Look].X;
                _LookUpDownAmount = _CurrentTouchSourceMovement[(int)TouchSourceMovementType.Look].Y;

                // Clamp the movement range.
                _TurnAmount = MathHelper.Clamp(_TurnAmount, -0.75f, 0.75f);
                _LookUpDownAmount = MathHelper.Clamp(_LookUpDownAmount, -1.0f, 1.0f);
            }
        }

        private Nullable<TouchLocation> FindInitialTouchSource(TouchSourceMovementType touchsourcetype, TouchState touch)
        {
            foreach (TouchLocation source in touch.TouchLocations)
            {
                if (source.SourceIsMouse || source.State != TouchLocationState.Pressed)
                    continue;

                if (touchsourcetype == TouchSourceMovementType.Look && source.NormalizedX > 0.5f)
                    continue;

                if (touchsourcetype == TouchSourceMovementType.Move && source.NormalizedX < 0.5f)
                    continue;

                return source;
            }

            return null;
        }

        private Nullable<TouchLocation> GetTouchSourceNextLocation(Nullable<TouchLocation> currentsource, TouchState touch)
        {
            if (!currentsource.HasValue)
                return null;

            foreach (TouchLocation nextsource in touch.TouchLocations)
            {
                if (currentsource.Value.Id == nextsource.Id)
                    return nextsource;
            }

            return null;
        }
    }
}
