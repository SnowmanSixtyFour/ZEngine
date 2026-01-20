using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace ZEngine.Source.Graphics
{
    internal class StaticSprite
    {
        private Texture2D texture;
        private Rectangle destRect;
        private Color color;

        public StaticSprite(Texture2D texture, Rectangle rect, Color color)
        {
            // Error check
            if (texture == null) texture = Global.noImg;

            // Initialize sprite
            setTexture(texture);
            setDestRect(rect);
            setColor(color);
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(texture, destRect, color);
        }

        // Getters

        public Texture2D getTexture()
        {
            return this.texture;
        }

        public Rectangle getDestRect()
        {
            return this.destRect;
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

        public void setDestRect(Rectangle newRect)
        {
            this.destRect = newRect;
        }

        public void setColor(Color newColor)
        {
            this.color = newColor;
        }
    }
}
