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
using ZEngine.Source.Graphics;
using ZEngine.Source.Objects;

namespace ZEngine.Source.States
{
    internal class Main : State
    {
        Character giovanni;
        Text debug;

        public Main()
        {
            giovanni = new Character(Global.gio, new Point(10, 10), new Point(48, 29), new Point(16, 29), Color.White);
            debug = new Text(Global.arial, "", new Vector2(10, 10), Color.White);
        }

        public override void OnUpdate(GameTime gameTime)
        {
            debug.setText("X: " + giovanni.X + "\nY :" + giovanni.Y);

            // Placeholder controls
            if (KeyDown(Keys.Left))
            {
                giovanni.X -= 2;
            }
            if (KeyDown(Keys.Right))
            {
                giovanni.X += 2;
            }
            if (KeyDown(Keys.Up))
            {
                giovanni.Y -= 2;
            }
            if (KeyDown(Keys.Down))
            {
                giovanni.Y += 2;
            }
        }

        public override void OnDraw(SpriteBatch spriteBatch)
        {
            graphicsDevice.Clear(Color.CornflowerBlue);

            debug.Draw(spriteBatch);
            giovanni.Draw(spriteBatch);
        }
    }
}
