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
using SynapseGaming.SunBurn.Engine.Collision;
using SynapseGaming.SunBurn.Engine.Collision.Controllers;
using SynapseGaming.SunBurn.Engine.Core;
using SynapseGaming.SunBurn.Engine.Editor;
using SynapseGaming.SunBurn.Engine.Rendering;
#endregion


namespace GameLibrary.Input
{
    public class InputHelper
    {
        private float _CharacterLookUpDownAngle;
        private float _FreeCameraMoveSpeed;
        private Vector3 _FreeCameraViewPosition;
        private Vector3 _FreeCameraViewRotation;
        private CompositeInputSource _InputSources;

        public InputHelper(float freecameramovespeed, Vector3 freecameraposition,
            Vector3 freecamerarotation, params BaseInputSource[] sources)
        {
            _FreeCameraMoveSpeed = freecameramovespeed;
            _FreeCameraViewPosition = freecameraposition;
            _FreeCameraViewRotation = freecamerarotation;

            _InputSources = new CompositeInputSource(sources);
        }

        public void Update()
        {
            _InputSources.Update();
        }

        public void HandleCharacterControllerInput(GameTime gametime, ICharacterController controller)
        {
            float timescale = (float)gametime.ElapsedGameTime.TotalSeconds;
            float rotatescale = 1.5f;

            // Avoid moving with keyboard and mouse when the editor is open.
            if (controller.PlayerNumber == 0 && SunBurnEditorClient.Instance.EditorOpen)
                return;

            // Apply player input.
            controller.Move(new Vector2(_InputSources.MoveAmount.X, 0.0f));
            controller.Move(new Vector2(0.0f, _InputSources.MoveAmount.Y));
            controller.Turn(-_InputSources.TurnAmount * rotatescale);

            if (_InputSources.Jump)
                controller.Jump();

            controller.Crouch = _InputSources.Crouch;

            // Apply up / down view.
            _CharacterLookUpDownAngle += _InputSources.LookUpDownAmount * rotatescale * timescale;

            // Clamp the look up / down range.
            _CharacterLookUpDownAngle = MathHelper.Clamp(_CharacterLookUpDownAngle, -1.0f, 1.0f);
        }

        public Matrix GetCharacterControllerView(ICharacterController controller)
        {
            // Get the controlled object (the CollidableEntity) from the controller.
            ICollisionObject obj = controller.ParentObject;

            // Need the direction it's facing and the world bounds.
            Vector3 forward = Vector3.Normalize(obj.World.Forward);
            BoundingBox worldbox = obj.WorldBoundingBox;

            // Calculate the eye location for the object.
            Vector3 eyelocation = Vector3.Zero;
            eyelocation.X = (worldbox.Max.X + worldbox.Min.X) * 0.5f;
            eyelocation.Z = (worldbox.Max.Z + worldbox.Min.Z) * 0.5f;
            eyelocation.Y = (worldbox.Max.Y - worldbox.Min.Y) * 0.9f + worldbox.Min.Y;

            // Convert it to a view matrix.
            return Matrix.Invert(Matrix.CreateRotationX(_CharacterLookUpDownAngle) * Matrix.CreateWorld(eyelocation, forward, Vector3.Up));
        }

        public Matrix GetFreeCameraView(GameTime gametime)
        {
            // Avoid moving with keyboard and mouse when the editor is open.
            if (!SunBurnEditorClient.Instance.EditorOpen)
            {
                float timescale = (float)gametime.ElapsedGameTime.TotalSeconds;
                float rotatescale = 150.0f * timescale;
                float movescale = timescale * _FreeCameraMoveSpeed;

                _FreeCameraViewRotation.X -= MathHelper.ToRadians(_InputSources.TurnAmount * rotatescale);
                _FreeCameraViewRotation.Y -= MathHelper.ToRadians(_InputSources.LookUpDownAmount * rotatescale);

                if (_FreeCameraViewRotation.Y > MathHelper.PiOver2 - 0.01f)
                    _FreeCameraViewRotation.Y = MathHelper.PiOver2 - 0.01f;
                else if (_FreeCameraViewRotation.Y < -MathHelper.PiOver2 + 0.01f)
                    _FreeCameraViewRotation.Y = -MathHelper.PiOver2 + 0.01f;

                Quaternion rot = Quaternion.CreateFromYawPitchRoll(_FreeCameraViewRotation.X, _FreeCameraViewRotation.Y, _FreeCameraViewRotation.Z);
                Vector3 scaledmove;

                scaledmove.X = _InputSources.MoveAmount.X * -movescale;
                scaledmove.Y = 0.0f;
                scaledmove.Z = _InputSources.MoveAmount.Y * movescale;

                _FreeCameraViewPosition += Vector3.Transform(scaledmove, rot);
            }

            // Convert the camera rotation and movement into a view transform.
            Matrix rotation = Matrix.CreateFromYawPitchRoll(_FreeCameraViewRotation.X, _FreeCameraViewRotation.Y, _FreeCameraViewRotation.Z);
            Vector3 target = _FreeCameraViewPosition + Vector3.Transform(Vector3.Backward, rotation);
            return Matrix.CreateLookAt(_FreeCameraViewPosition, target, Vector3.Up);
        }
    }
}
