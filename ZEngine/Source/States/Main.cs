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
            // Test Character
            giovanni = new Character(Global.gio, new Point(10, 200), new Point(48, 29), new Point(16, 29), Color.White);
            giovanni.SetSize(2);

            // Test Create Animations
            giovanni.CreateAnimation("idle", 0, 0);
            giovanni.CreateAnimation("walk", 1, 2);

            debug = new Text(Global.arial, "", new Vector2(10, 10), Color.White, 1.0f);
        }

        public override void OnUpdate(GameTime gameTime)
        {
            // Entire Main OnUpdate method is a placeholder; testing out Character and animations, Text and more

            // Text
            debug.setText("X: " + giovanni.X
                + "\nY: " + giovanni.Y
                + "\nWidth: " + giovanni.Width
                + "\nHeight: " + giovanni.Height);

            // Char Movement
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

            // Char Animations
            if (!KeyDown(Keys.Left) // Idle
                && !KeyDown(Keys.Right)
                && !KeyDown(Keys.Up)
                && !KeyDown(Keys.Down))
            {
                giovanni.PlayAnimation("idle");
            }
            else // Walking
            {
                giovanni.PlayAnimation("walk");
            }

            // Toggle Filter
            if (KeyPress(Keys.Enter))
            {
                Global.shadersEnabled = !Global.shadersEnabled;
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
