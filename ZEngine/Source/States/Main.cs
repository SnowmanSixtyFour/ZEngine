// The main state of the game.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ZEngine.Source.Graphics;
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
            cam = new Camera(this.graphicsDevice.Viewport);
        }

        public override void Update(GameTime gameTime)
        {
            cam.Update(gameTime, giovanni);

            base.Update(gameTime);
        }

        public override void OnDraw(SpriteBatch spriteBatch)
        {
            graphicsDevice.Clear(Color.CornflowerBlue);

            giovanni.Draw(spriteBatch);
        }
    }
}
