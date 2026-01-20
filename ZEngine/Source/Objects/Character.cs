using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ZEngine.Source.Graphics;

namespace ZEngine.Source.Objects
{
    internal class Character
    {
        public int X, Y, Width, Height;
        private Sprite sprite;

        public Character(Texture2D texture, Point location, Point size, Point sheetSize, Color color)
        {
            // Set variables
            this.X = location.X;
            this.Y = location.Y;
            this.Width = size.X / 3;
            this.Height = size.Y;

            // Create Sprite
            sprite = new Sprite(texture, new Rectangle(location, new Point(this.Width, this.Height)), new Rectangle(new Point(0, 0), sheetSize), color);
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            sprite.Draw(spriteBatch);
        }

        // Setters

        public void CreateNewAnim(String name, int frames)
        {
        }
    }
}
