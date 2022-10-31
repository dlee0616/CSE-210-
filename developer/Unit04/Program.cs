using System;
using Greed.Casting;

namespace Greed
{
    //parent class gem 
    public class gem
    {
        // Declare global vars for gem
        string _symbol;
        // Constructor
        public gem (string symbol)
        {
            _symbol = symbol;
        }

        // Shoot the object in a random place
        public void obstacle()
        {
            string _gem = "*";
            // Console.WriteLine(_gem);
        }
    }

    //child class rock
    public class rock : gem
    {
        public string rockVar = "[ ]";
    }

    //class for game
    public class Program 
    {
        public static void Main()
        {
            gem myGem = new gem("*");
            rock fall = new rock();
            fall.obstacle();
            fall.obstacle(rock);
        }
    }
}
