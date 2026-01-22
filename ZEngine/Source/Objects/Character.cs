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
        // Public variables
        public int X, Y, Width, Height;

        // Protected variables
        protected int resize = 1, defaultWidth, defaultHeight;
        protected Sprite sprite;

        public Character(Texture2D texture, Point location, Point size, Point sheetSize, Color color)
        {
            // Set variables
            this.X = location.X;
            this.Y = location.Y;
            this.defaultWidth = (size.X / 3);
            this.defaultHeight = size.Y;
            UpdateSize();

            // Create Sprite
            sprite = new Sprite(texture,                // Texture
                new Rectangle(new Point(X, Y),          // Position
                new Point(this.Width, this.Height)),    // Size
                new Rectangle(new Point(0, 0),          // Sprite Sheet Frame Position
                sheetSize),                             // Sprite Sheet Size
                color);                                 // Color
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            // Update

            // Sprite (Position & Size)
            sprite.setDestRect(new Rectangle(new Point(X, Y), new Point(Width * resize, Height * resize)));

            // Draw

            sprite.Draw(spriteBatch);
        }

        public void CreateNewAnim(String name, int frames)
        {
        }

        // Setters

        public void setSize(int newSize)
        {
            this.resize = newSize;

            UpdateSize();
        }

        private void UpdateSize()
        {
            this.Width = (defaultWidth * resize);
            this.Height = (defaultHeight * resize);
        }
    }
}
