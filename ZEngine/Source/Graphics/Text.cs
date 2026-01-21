using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace ZEngine.Source.Graphics
{
    internal class Text
    {
        protected SpriteFont font;
        protected String text;
        protected Vector2 position;
        protected Color color;

        public Text(SpriteFont font, String text, Vector2 position, Color color)
        {
            // Initialize text
            setFont(font);
            setText(text);
            setPosition(position);
            setColor(color);
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.DrawString(font, text, position, color);
        }

        // Getters

        public SpriteFont getFont()
        {
            return this.font;
        }

        public String getText()
        {
            return this.text;
        }

        public Vector2 getPosition()
        {
            return this.position;
        }

        public Color getColor()
        {
            return this.color;
        }

        // Setters

        public void setFont(SpriteFont newFont)
        {
            this.font = newFont;
        }

        public void setText(String newText)
        {
            this.text = newText;
        }

        public void setPosition(Vector2 newPosition)
        {
            this.position = newPosition;
        }

        public void setColor(Color newColor)
        {
            this.color = newColor;
        }
    }
}
