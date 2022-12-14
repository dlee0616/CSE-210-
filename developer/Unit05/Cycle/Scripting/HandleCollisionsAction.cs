using System;
using System.Collections.Generic;
using System.Data;
using Unit05.Game.Casting;
using Unit05.Game.Services;


namespace Unit05.Game.Scripting
{
    /// <summary>
    /// <para>An update action that handles interactions between the actors.</para>
    /// <para>
    /// The responsibility of HandleCollisionsAction is to handle the situation when the snake 
    /// collides with the food, or the snake collides with its segments, or the game is over.
    /// </para>
    /// </summary>
    public class HandleCollisionsAction : Action
    {
        private bool _isGameOver = false;

        /// <summary>
        /// Constructs a new instance of HandleCollisionsAction.
        /// </summary>
        public HandleCollisionsAction()
        {
        }

        /// <inheritdoc/>
        public void Execute(Cast cast, Script script)
        {
            if (_isGameOver == false)
            {
                //HandleFoodCollisions(cast);
                HandleSegmentCollisions(cast);
                HandleGameOver(cast);
            }
        }

        /// <summary>
        /// Updates the score nd moves the food if the snake collides with it.
        /// </summary>
        /// <param name="cast">The cast of actors.</param>
        // private void HandleFoodCollisions(Cast cast)
        // {
        //     Snake snake = (Snake)cast.GetFirstActor("snake");
        //     Score score = (Score)cast.GetFirstActor("score");
        //     Food food = (Food)cast.GetFirstActor("food");
            
        //     if (snake.GetHead().GetPosition().Equals(food.GetPosition()))
        //     {
        //         int points = food.GetPoints();
        //         snake.GrowTail(points);
        //         score.AddPoints(points);
        //         food.Reset();
        //     }
        // }

        /// <summary>
        /// Sets the game over flag if the snake collides with one of its segments.
        /// </summary>
        /// <param name="cast">The cast of actors.</param>

        private Boolean GetIsCollision(Snake snake, Actor head) {
            foreach (Actor segment in snake.GetBody())
            {
                if (head.GetPosition().Equals(segment.GetPosition()))
                {
                    return true;
                }
            }
            return false;
        }

        private void HandleSegmentCollisions(Cast cast)
        {
            // get snakes
            Snake snake = (Snake)cast.GetFirstActor("snake");
            Actor head = snake.GetHead();

            Snake snake2 = (Snake)cast.GetFirstActor("secondSnake");
            Actor head2 = snake2.GetHead();
            Score score;

            if (GetIsCollision(snake, head2)) {
                // snake 2 hit snake 1
                _isGameOver = true;
                score = (Score)cast.GetFirstActor("score");
                score.AddPoints(1);                
                // make everything white
                foreach (Actor segment in snake.GetBody())
                {
                    segment.SetColor(Constants.WHITE);
                }
                foreach (Actor segment in snake2.GetBody())
                {
                    segment.SetColor(Constants.WHITE);
                }
               
            } 

            if (GetIsCollision(snake2, head))
            {
                // snake 1 hit snake 2
                _isGameOver = true;
                score = (Score)cast.GetFirstActor("secondScore");
                score.AddPoints(1);
                // make everything white
                foreach (Actor segment in snake2.GetBody())
                {
                    segment.SetColor(Constants.WHITE);
                }
                foreach (Actor segment in snake.GetBody())
                {
                    segment.SetColor(Constants.WHITE);
                }
            }
        }

        private void HandleGameOver(Cast cast)
        {
            if (_isGameOver == true)
            {
                Snake snake = (Snake)cast.GetFirstActor("snake");
                // Food food = (Food)cast.GetFirstActor("food"); 

                // create a "game over" message
                int x = Constants.MAX_X / 2;
                int y = Constants.MAX_Y / 2;
                Point position = new Point(x, y);

                Actor message = new Actor();
                message.SetText("Game Over!");
                message.SetPosition(position);
                cast.AddActor("message", message);
            }
        }

    }
}