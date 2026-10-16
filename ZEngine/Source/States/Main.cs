// The main state of the game.

using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using ZEngine.Source.Graphics;
using ZEngine.Source.Objects;

namespace ZEngine.Source.States
{
    internal class Main : State
    {
        private State currentState;

        private Level level;

        public Main()
        {
            // Set States
            level = new Level();

            // Set Current State
            currentState = level;

            // Set Objects
            cursor.X = 0;
            cursor.Y = 0;
        }

        public override void OnUpdate(GameTime gameTime)
        {
            // Pausing
            if (canPause) // If Pausing is Possible
            {
                // Toggle Pause
                if (KeyPress(Keys.Escape))
                {
                    Global.paused = !Global.paused;
                }
            }

            // Mouse Visibility
            Global.mouseVisible = Global.paused;

            // Pause Game when Inactive
            if (Global.pauseWhenInactive && !Global.active) Global.paused = true;

            // Center Mouse
            if (!Global.paused && Global.active)
            {
                if (MouseMoved())
                {
                    // Keep Mouse Centered
                    cursor.X += (mouse.X - screenWidth / 2);
                    cursor.Y += (mouse.Y - screenHeight / 2);
                }

                // Cursor Bounds
                if (cursor.X < 0) cursor.X = 0; // Left
                if (cursor.X > cam.Width - Global.cursorSize.X) cursor.X = cam.Width - Global.cursorSize.X;   // Right
                if (cursor.Y < 0) cursor.Y = 0; // Top
                if (cursor.Y > cam.Height - Global.cursorSize.Y) cursor.Y = cam.Height - Global.cursorSize.Y; // Bottom

                // Center Mouse
                Mouse.SetPosition(screenWidth / 2, screenHeight / 2);
            }

            // Update Current State
            currentState.Update(gameTime);
            cursor.Update(gameTime);
        }

        public override void OnDraw(SpriteBatch spriteBatch)
        {
            // Draw Current State
            currentState.OnDraw(spriteBatch);
        }
    }
}
