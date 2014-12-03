using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Asteroid_Belt_Assault
{
    class Planets
    {
        private List<Sprite> planets = new List<Sprite>();
        private int screenWidth = 800;
        private int screenHeight = 600;
        private Random rand = new Random();
        private Color[] colors = { Color.White, Color.Yellow, 
                           Color.Wheat, Color.WhiteSmoke, 
                           Color.SlateGray };

            public Planets(
            int screenWidth,
            int screenHeight,
            int planetCount,
            Vector2 planetVelocity,
            Texture2D texture,
            Rectangle frameRectangle)
        {
            this.screenWidth = screenWidth;
            this.screenHeight = screenHeight;
            for (int x = 0; x < planetCount; x++)
            {
                planets.Add(new Sprite(
                    new Vector2(rand.Next(0, screenWidth),
                        rand.Next(0, screenHeight)),
                    texture,
                    frameRectangle,
                    planetVelocity));
                Color starColor = colors[rand.Next(0, colors.Count())];
                starColor *= (float)(rand.Next(30, 80) / 100f); planets[planets.Count() - 1].TintColor = starColor;
            }
        }

        public void Update(GameTime gameTime)
        {
            foreach (Sprite planet in planets)
            {
                planets[i].Update(gameTime);
                if (planet.Location.Y > screenHeight)
                {
                    planet.Location = new Vector2(
                        rand.Next(0, screenWidth), 0);
                }
            }
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            foreach (Sprite planet in planets)
            {
                planets.Draw(spriteBatch);
            }
        }

    }

    }
}
