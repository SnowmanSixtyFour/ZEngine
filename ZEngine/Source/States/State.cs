// The template class for a state in the game.
// A state is a different scene.

/*
 * Templates:
 * 
 * To Update:
 * public override void Update(GameTime gameTime)
 * 
 * To Draw:
 * public override void OnDraw(SpriteBatch spriteBatch)
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using ZEngine.Source.Objects;

namespace ZEngine.Source.States
{
    internal class State
    {
        public GraphicsDeviceManager graphics = MainGame.publicGraphics;
        public GraphicsDevice graphicsDevice = MainGame.publicGraphicsDevice;

        // State variables
        public KeyboardState keyboard, previousKeyboard;
        public MouseState mouse, previousMouse;
        public int screenWidth, screenHeight;
        public Camera cam;

        public State()
        {
            // Set Camera
            cam = new Camera(this.graphicsDevice, Global.windowWidth, Global.windowHeight);
        }

        public void Update(GameTime gameTime)
        {
            // Update state variables
            screenWidth = graphicsDevice.Viewport.Width;
            screenHeight = graphicsDevice.Viewport.Height;

            // Controls
            keyboard = Keyboard.GetState();

            // Override Update
            OnUpdate(gameTime);

            previousKeyboard = keyboard;
        }

        public virtual void OnUpdate(GameTime gameTime)
        {
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            OnDraw(spriteBatch);
        }

        /// <summary>
        /// The method to override when drawing in the state.
        /// </summary>
        /// <param name="spriteBatch">The spriteBatch used in Draw.</param>
        public virtual void OnDraw(SpriteBatch spriteBatch)
        {
        }

        // Controls

        public bool KeyPress(Keys key)
        {
            if (keyboard.IsKeyUp(key) && previousKeyboard.IsKeyDown(key))
            {
                return true;
            }
            else return false;
        }

        public bool KeyDown(Keys key)
        {
            if (keyboard.IsKeyDown(key))
            {
                return true;
            }
            else return false;
        }
    }
}
