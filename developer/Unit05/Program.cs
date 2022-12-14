using System;
using Unit05.Game;
using Unit05.Game.Casting;
using Unit05.Game.Directing;
using Unit05.Game.Scripting;
using Unit05.Game.Services;
namespace Unit05
{
    class Program
    {
        static void Main(string[] args)
        {
            Cast cast = new Cast();

            // create actors
            // create snake & score for snake instance #1
            cast.AddActor("snake", new Snake(1));
            cast.AddActor("score", new Score(1));
            //cast.AddActor("prompt", new  )

            // create snake & score for snake instance #2
            cast.AddActor("secondSnake", new Snake(2));
            cast.AddActor("secondScore", new Score(2));

            //create services 
            KeyboardService keyboardService = new KeyboardService();
            VideoService videoService = new VideoService(false);

            // create script 
            Script script = new Script();
            script.AddAction("input", new ControlActorsAction(keyboardService));
            script.AddAction("update", new MoveActorsAction());
            script.AddAction("update", new HandleCollisionsAction());
            script.AddAction("output", new DrawActorsAction(videoService));

            // start the game
            Director director = new Director(videoService);
            director.StartGame(cast, script);
        }
    }
}
