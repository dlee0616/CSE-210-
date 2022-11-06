
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Unit04.Game.Casting;
using Unit04.Game.Directing;
using Unit04.Game.Services;

namespace Greed
{
    class Program 

    {
        private static int FRAME_RATE = 12;
        private static int MAX_X = 900;
        private static int MAX_Y = 600;
        private static int CELL_SIZE = 15;
        private static int FONT_SIZE = 15;
        private static int COLS = 60;
        private static int ROWS = 40;
        private static string CAPTION = "Robot Finds Kitten";
        private static string DATA_PATH = "Data/messages.txt";
        private static Color WHITE = new Color(255, 255, 255);
        private static int DEFAULT_ARTIFACTS = 40;
        static void Main(string[] args)
        {

        
        // start the game
        KeyboardService keyboardService = new KeyboardService(cellSize);
        VideoService videoService = new VideoService(text, MAX_X, MAX_Y, CELL_SIZE, FRAME_RATE, false);
        Director director = new Director(keyboardService, videoService);
        Director.StartGame(cast);
        }
    }
}
   
