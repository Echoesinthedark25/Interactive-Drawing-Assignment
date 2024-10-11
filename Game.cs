// Include code libraries you need below (use the namespace).
using System;
using System.Numerics;

// The namespace your code is in.
namespace Game10003
{
    /// <summary>
    ///     Your game code goes inside this class!
    /// </summary>
    public class Game
    {
        // Place your variables here:
        Color BlackBG = Color.Black;
        Color White = Color.White;
        Color Red = Color.Red;

        float[] xCoordinates = [];
        float[] yCoordinates = [];

        /// <summary>
        ///     Setup runs once before the game loop begins.
        /// </summary>
        public void Setup()
        {
            Window.SetTitle("Hunters Mark");
            Window.SetSize(400, 400);

            int count = Random.Integer(0, 100);
            xCoordinates = new float[count];
            yCoordinates = new float[count];
            for (int i = 0; i < count; i++)
            {
                xCoordinates[i] = 
            }
        }

        /// <summary>
        ///     Update runs every frame.
        /// </summary>
        public void Update()
        {
            Window.ClearBackground(BlackBG);

            Draw.FillColor = White;
            Draw.LineSize = 0;
            {
                Draw.Circle()
            }
        }
    }
}
