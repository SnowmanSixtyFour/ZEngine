using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace ZEngine.Source.Graphics
{
    internal class Sprite : StaticSprite
    {
        public int frames;
        public Rectangle sourceRect;

        public Sprite(Texture2D texture, Rectangle destRect, Rectangle sourceRect, Color color) : base(texture, destRect, color)
        {
            // Error check
            if (texture == null) texture = Global.noImg;

            // Initialize sprite
            setTexture(texture);
            setDestRect(destRect);
            setSourceRect(sourceRect);
            setColor(color);
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(getTexture(), getDestRect(), sourceRect, getColor());
        }

        // Getters

        public Rectangle getSourceRect()
        {
            return this.sourceRect;
        }

        // Setters

        public void setSourceRect(Rectangle newRect)
        {
            this.sourceRect = newRect;
        }
    }
}
