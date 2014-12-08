using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
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
        private Texture2D texture;

        public Planets(
            int screenWidth,
            int screenHeight,
            Vector2 planetVelocity,
            Texture2D texture)
            
        {
            this.texture = texture;
            this.screenWidth = screenWidth;
            this.screenHeight = screenHeight;


            SpawnPlanet();
        }


        public void SpawnPlanet()
        {
            int choice = rand.Next(0, 5);

            Rectangle frameRectangle = new Rectangle(0, 0, 0, 0);
            
            switch (choice)
            {
                case 0: frameRectangle = new Rectangle(0, 0, 370, 370); break;
                case 1: frameRectangle = new Rectangle(0, 370, 138, 138); break;
                case 2: frameRectangle = new Rectangle(380, 343, 152, 152); break;
                case 3: frameRectangle = new Rectangle(390, 15, 285, 285); break;
                case 4: frameRectangle = new Rectangle(700, 285, 217, 217); break;
            }

            Sprite planet = new Sprite(new Vector2(rand.Next(100,this.screenWidth-100), -400), texture, frameRectangle, new Vector2(0, 50));
            planet.TintColor = new Color(0.5f, 0.5f, 0.5f);

            planets.Add(planet);
           //     planets = new Planets(600, 800, new Vector2(0, 10), (rand.choice))
            

        }

        public void Update(GameTime gameTime)
        {
            for (int i = planets.Count-1; i >= 0; i--)
            {
                Sprite planet = planets[i];

                planet.Update(gameTime);
                if (planet.Location.Y > screenHeight + 400)
                {
                    planets.RemoveAt(i);
                    SpawnPlanet();
                }
            }
            




        }

        public void Draw(SpriteBatch spriteBatch)
        {
            for (int i = 0; i < planets.Count; i++)
            {
                planets[i].Draw(spriteBatch);
            }
        }

    }

    }

