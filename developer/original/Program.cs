﻿using System;
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
            //create actors
            Cast cast = new Cast();
            cast.AddActor("snake", new Snake());
            cast.AddActor("SecondSnake", new Snake());
            cast.AddActor("SecondScore", new Score());
            cast.AddActor("score", new Score());

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