using System.Collections.Generic;
using Unit05.Game.Casting;
using Unit05.Game.Services;


namespace Unit05.Game.Scripting
{
    /// <summary>
    /// <para>An output action that draws all the actors.</para>
    /// <para>The responsibility of DrawActorsAction is to draw (display) each of the actors.</para>
    /// </summary>
    public class DrawActorsAction : Action
    {
        private VideoService _videoService;

        /// <summary>
        /// Constructs a new instance of ControlActorsAction using the given KeyboardService.
        /// </summary>
        public DrawActorsAction(VideoService videoService)
        {
            this._videoService = videoService;
        }

        /// <inheritdoc/>
        public void Execute(Cast cast, Script script)
        {
            // Select the actors
            Snake snake = (Snake)cast.GetFirstActor("snake");
            Snake snake2 = (Snake)cast.GetSecondActor("SecondSnake");
            List<Actor> segments = snake.GetSegments();
            List<Actor> segments2 = snake2.GetSegments();
            Actor score = cast.GetFirstActor("score");
            Actor score2 = cast.GetSecondActor("SecondScore");
            // Actor food = cast.GetFirstActor("food");
            
            // Display them
            _videoService.ClearBuffer();
            _videoService.DrawActors(segments);
            _videoService.DrawActors(segments2);
            _videoService.DrawActor(score);
            _videoService.DrawActor(score2);
            // _videoService.DrawActor(food);
            //_videoService.DrawActors(messages);
            _videoService.FlushBuffer();
        }
    }
}