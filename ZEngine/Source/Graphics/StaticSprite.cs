using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZEngine.Source.Graphics
{
    internal class StaticSprite
    {
        private Texture2D texture;
        private Rectangle rect;
        private Color color;

        public StaticSprite(Texture2D texture, Rectangle rect, Color color)
        {
            // Initialize sprite
            setTexture(texture);
            setRect(rect);
            setColor(color);
        }

        // Getters

        public Texture2D getSprite()
        {
            return this.texture;
        }

        public Rectangle getRect()
        {
            return this.rect;
        }

        public Color getColor()
        {
            return this.color;
        }

        // Setters

        public void setTexture(Texture2D newTexture)
        {
            this.texture = newTexture;
        }

        public void setRect(Rectangle newRect)
        {
            this.rect = newRect;
        }

        public void setColor(Color newColor)
        {
            this.color = newColor;
        }
    }
}
