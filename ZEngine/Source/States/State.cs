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

namespace ZEngine.Source.States
{
    internal class State
    {
        public GraphicsDeviceManager graphics = MainGame.publicGraphics;
        public GraphicsDevice graphicsDevice = MainGame.publicGraphicsDevice;

        // State variables
        public int screenWidth, screenHeight;

        public State()
        {
        }

        public virtual void Update(GameTime gameTime)
        {
            // Update state variables
            screenWidth = graphicsDevice.Viewport.Width;
            screenHeight = graphicsDevice.Viewport.Height;
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
    }
}
