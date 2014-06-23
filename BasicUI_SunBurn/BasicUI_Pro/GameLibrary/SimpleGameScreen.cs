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
using SynapseGaming.SunBurn.Engine.Collision;
using SynapseGaming.SunBurn.Engine.Collision.Controllers;
using SynapseGaming.SunBurn.Engine.Editor;
using SynapseGaming.SunBurn.Engine.Rendering;
using GameLibrary.Input;


namespace GameLibrary
{
    /// <summary>
    /// Sample screen for the game, which can render in-game scenes, ui, or similar.
    /// </summary>
    public class SimpleGameScreen : GameScreen
    {
        // The SunBurn engine.
        ContentRepository contentRepository;
        SceneInterface sceneInterface;
        FrameBuffers frameBuffers;
        SceneState sceneState;
        SceneEnvironment environment;

        // Scene/camera supporting members.
        Matrix view = Matrix.Identity;
        Matrix projection = Matrix.Identity;

        InputHelper inputHelper = new InputHelper(10.0f,// free camera move speed
            Vector3.Zero,// free camera initial position
            Vector3.Zero,// free camera initial rotation
            new GamepadInputSource(0),// accept gamepad input from player 0
            new KeyboardInputSource(),// accept keyboard input
            new MouseInputSource(),// accept mouse input
            new TouchInputSource());// accept touch input

        public SimpleGameScreen()
        {
            sceneState = new SceneState();

            // Create the scene interface. Acts as a service provider containing all scene managers
            // and returning them by type (including custom managers). Also acts as a component
            // container where calls to manager methods on the SceneInterface (such as BeginFrameRendering,
            // Unload, ...) are automatically called on all contained managers.
            //
            // This design allows managers to be plugged-in like modular components and for managers
            // to easily be added, removed, or replaced with custom implementations.
            //
            sceneInterface = new SceneInterface();
            sceneInterface.CreateDefaultManagers(RenderingSystemType.Forward, CollisionSystemType.Physics, true);

            BaseGameProgram.Instance.OnInitializeSceneInterface(sceneInterface);

            // Create the frame buffers used for rendering (sized to the backbuffer) and
            // assign them to the ResourceManager so we don't have to worry about cleanup.
            frameBuffers = new FrameBuffers(DetailPreference.High, DetailPreference.High);
            sceneInterface.ResourceManager.AssignOwnership(frameBuffers);
        }

        /// <summary>
        /// Called when the program switches to the screen. This is
        /// where screen assets are loaded and resources are created.
        /// </summary>
        public override void LoadContent()
        {
            // Load the content repository, which stores all assets imported via the editor.
            // This must be loaded before any other assets.
            contentRepository = BaseGameProgram.Instance.ContentDatabase.Load<ContentRepository>("ContentRepository");

            // Load the scene and add it to the managers.
            Scene scene = BaseGameProgram.Instance.ContentDatabase.Load<Scene>("Scene");
            sceneInterface.Submit(scene);

            // Load the scene settings.
            environment = BaseGameProgram.Instance.ContentDatabase.Load<SceneEnvironment>("SceneEnvironment");

            // Apply the user preferences (example - not required).
            sceneInterface.ApplyPreferences(BaseGameProgram.Instance.GetSystemPreferences());
        }

        /// <summary>
        /// Called when the program switches away from this screen
        /// and is where screen resources are disposed.
        /// </summary>
        public override void UnloadContent()
        {
            sceneInterface.Unload();
            environment = null;
            contentRepository = null;
        }

        /// <summary>
        /// Allows the screen to run logic such as updating the world,
        /// checking for collisions, gathering input, and playing audio.
        /// </summary>
        /// <param name="gameTime">Provides the time elapsed since the last screen draw / update.</param>
        public override void Update(GameTime gameTime)
        {
            GraphicsDevice graphics = Platform.Instance.GraphicsDevice;
            InputDevice input = Platform.Instance.InputDevice;

            if (input.KeyboardState.KeyPressed(Keys.Escape) && !SunBurnEditorClient.Instance.EditorOpen)
            {
                Platform.Instance.RunAsGameLoop.Exit();
                return;
            }

            // Update the helper with the latest player input.
            inputHelper.Update();

            // Move each character controller.
            ICharacterController chasecontroller = null;
            foreach (ICharacterController controller in PhysicsMoveCharacterController.CharacterControllers)
            {
                inputHelper.HandleCharacterControllerInput(gameTime, controller);

                // Chase camera follows player one if available.
                if (controller.PlayerNumber == 0)
                    chasecontroller = controller;
            }

            // Update the scene interface.
            sceneInterface.Update(gameTime);

            // Set the view matrix.
            if (chasecontroller != null)
                view = inputHelper.GetCharacterControllerView(chasecontroller);
            else
                view = inputHelper.GetFreeCameraView(gameTime);

            // Set the projection matrix.
            projection = Matrix.CreatePerspectiveFieldOfView(MathHelper.ToRadians(70.0f),
                graphics.Viewport.AspectRatio, 0.1f, environment.VisibleDistance);
        }

        /// <summary>
        /// Allows the screen to render.
        /// </summary>
        /// <param name="gameTime">Provides the time elapsed since the last screen draw / update.</param>
        public override void Draw(GameTime gameTime)
        {
            // Render the scene.
            sceneState.BeginFrameRendering(view, projection, gameTime, environment, frameBuffers, true);
            sceneInterface.BeginFrameRendering(sceneState);

            // Add custom rendering that should occur before the scene is rendered.

            sceneInterface.RenderManager.Render();

            // Add custom rendering that should occur after the scene is rendered.

            sceneInterface.EndFrameRendering();
            sceneState.EndFrameRendering();
        }
    }
}
