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

        // Animation variables
        Point sheetSize;
        float
            elapsed,
            delay = 200f;
        int frame = 0, maxFrames = 2;

        public Character(Texture2D texture, Point location, Point size, Point sheetSize, Color color)
        {
            // Set variables
            this.X = location.X;
            this.Y = location.Y;
            this.defaultWidth = (size.X / 3);
            this.defaultHeight = size.Y;
            this.sheetSize = sheetSize;
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
            // Test Animation Code Start
            elapsed += (float)MainGame.gameTime.ElapsedGameTime.TotalMilliseconds;

            if (elapsed >= delay)
            {
                // Go back to first frame
                if (frame >= maxFrames)
                {
                    frame = 0;
                }
                // Update frame
                else
                {
                    frame++;
                }

                // Reset animation time
                elapsed = 0;
            }
            // Test Animation Code End

            // Update

            // Sprite
            sprite.setDestRect(new Rectangle(
                new Point(X, Y),
                new Point(Width * resize, Height * resize)));

            // Current Frame of Sprite Sheet
            sprite.setSourceRect(new Rectangle(
                new Point((sheetSize.X * frame), 0),
                new Point(sheetSize.X, sheetSize.Y)));

            // Draw

            sprite.Draw(spriteBatch);
        }

        // Animate

        public void CreateAnimation(String name, int frames)
        {
        }

        public void PlayAnimation()
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
