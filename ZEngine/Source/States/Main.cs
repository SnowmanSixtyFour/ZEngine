// The main state of the game.

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using ZEngine.Source.Objects;

namespace ZEngine.Source.States
{
    internal class Main : State
    {
        Character giovanni;
        public Camera cam;

        public Main()
        {
            giovanni = new Character(Global.gio, new Point(10, 10), new Point(48, 29), new Point(16, 29), Color.White);
            cam = new Camera(this.graphicsDevice, Global.windowWidth, Global.windowHeight);
        }

        public override void OnUpdate(GameTime gameTime)
        {
            // Placeholder controls
            if (KeyDown(Keys.Left))
            {
                giovanni.X += 2;
            }
            if (KeyDown(Keys.Right))
            {
                giovanni.X -= 2;
            }
        }

        public override void OnDraw(SpriteBatch spriteBatch)
        {
            graphicsDevice.Clear(Color.CornflowerBlue);

            giovanni.Draw(spriteBatch);
        }
    }
}
