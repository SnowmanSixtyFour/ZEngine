// The main state of the game.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace ZEngine.Source.States
{
    internal class Main : State
    {
        public override void Update(GameTime gameTime)
        {
            base.Update(gameTime);
        }

        public override void OnDraw(SpriteBatch spriteBatch)
        {
            graphicsDevice.Clear(Color.CornflowerBlue);
        }
    }
}
