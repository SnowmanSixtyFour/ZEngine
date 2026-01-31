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

        // Settings

        public static bool renderInactive = true;

        // Graphics

        public static bool shadersEnabled = false;

        // Sprites

        public static Texture2D noImg, gio;
        public static SpriteFont arial;
        public static Effect crt;

        // Load game assets
        public static void LoadContent(ContentManager content)
        {
            // Images

            Global.noImg = content.Load<Texture2D>("Assets/Images/pixel");

            Global.gio = content.Load<Texture2D>("Assets/Images/Giovanni");

            // Fonts

            Global.arial = content.Load<SpriteFont>("Assets/Fonts/Arial");

            // Shaders

            Global.crt = content.Load<Effect>("Assets/Shaders/CRTFilter");
        }
    }
}
