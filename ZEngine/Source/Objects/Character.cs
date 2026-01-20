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
        private Sprite sprite;

        public Character(Texture2D texture, Point location, Point size, Point sheetSize, Color color)
        {
            sprite = new Sprite(texture, new Rectangle(location, new Point(size.X / 3, size.Y)), new Rectangle(new Point(0, 0), sheetSize), color);
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
