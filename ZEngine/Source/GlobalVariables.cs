using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace ZEngine.Source
{
    internal class Global
    {
        // Window

        public static string windowName = "Z Engine";

        public static int
            windowWidth = 844,
            windowHeight = 480;

        // Sprites

        public static Texture2D noImg, gio;

        // Load game assets
        public static void LoadContent(ContentManager content)
        {
            Global.noImg = content.Load<Texture2D>("Assets/Images/pixel");

            Global.gio = content.Load<Texture2D>("Assets/Images/Giovanni");
        }
    }
}
