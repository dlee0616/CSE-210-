using System;
using System.Collections.Generic;
using System.Linq;
using Unit05.Game.Scripting;
using Unit05.Game.Services;

namespace Unit05.Game.Casting
{
    /// <summary>
    /// <para>A long limbless reptile.</para>
    /// <para>The responsibility of Snake is to move itself.</para>
    /// </summary>
    public class Snake : Actor
    {
        private List<Actor> _segments = new List<Actor>();
        private int _spacesMoved;

        /// <summary>
        /// Constructs a new instance of a Snake.
        /// </summary>
        public Snake(int snakeIndex)
        {
            PrepareBody(snakeIndex);
            _spacesMoved = 0;
        }

        /// <summary>
        /// Gets the snake's body segments.
        /// </summary>
        /// <returns>The body segments in a List.</returns>
        public List<Actor> GetBody()
        {
            return new List<Actor>(_segments.Skip(1).ToArray());
        }

        /// <summary>
        /// Gets the snake's head segment.
        /// </summary>
        /// <returns>The head segment as an instance of Actor.</returns>
        public Actor GetHead()
        {
            return _segments[0];
        }

        /// <summary>
        /// Gets the snake's segments (including the head).
        /// </summary>
        /// <returns>A list of snake segments as instances of Actors.</returns>
        public List<Actor> GetSegments()
        {
            return _segments;
        }

        /// <summary>
        /// Grows the snake's tail by the given number of segments.
        /// </summary>
        /// <param name="numberOfSegments">The number of segments to grow.</param>
        public void GrowTail(int numberOfSegments)
        {
            for (int i = 0; i < numberOfSegments; i++)
            {
                Actor tail = _segments.Last<Actor>();
                Point velocity = tail.GetVelocity();
                Point offset = velocity.Reverse();
                Point position = tail.GetPosition().Add(offset);

                Actor segment = new Actor();
                segment.SetPosition(position);
                segment.SetVelocity(velocity);
                segment.SetText("#");
                segment.SetColor(Constants.GREEN);
                segment.SetColor(Constants.YELLOW);
                _segments.Add(segment);
            }
        }

        public void AutomaticGrowth() 
        {
            if (_spacesMoved % Constants.GROWTH_RATE == 0) {
                GrowTail(1);
            }
        }

        /// <inheritdoc/>
        public override void MoveNext()
        {
            _spacesMoved += 1;
            AutomaticGrowth();

            foreach (Actor segment in _segments)
            {
                segment.MoveNext();
            }

            for (int i = _segments.Count - 1; i > 0; i--)
            {
                Actor trailing = _segments[i];
                Actor previous = _segments[i - 1];
                Point velocity = previous.GetVelocity();
                trailing.SetVelocity(velocity);
            }
        }

        /// <summary>
        /// Turns the head of the snake in the given direction.
        /// </summary>
        /// <param name="velocity">The given direction.</param>
        public void TurnHead(Point direction)
        {
            _segments[0].SetVelocity(direction);
        }

        private Point getStartPosition(int snakeIndex, int index) {
            int startX = Constants.MAX_X / snakeIndex;
            int startY = Constants.MAX_Y / snakeIndex;
            return new Point(startX - index * Constants.CELL_SIZE, startY);
        }

        /// <summary>
        /// Prepares the snake body for moving.
        /// </summary>
        private void PrepareBody(int snakeIndex)
        {
            for (int i = 0; i < Constants.SNAKE_LENGTH; i++)
            {
                Point position = getStartPosition(snakeIndex, i);
                Point velocity = new Point(1 * Constants.CELL_SIZE, 0);
                string text = i == 0 ? "8" : "#";
                Color color = i == 0 ? Constants.YELLOW : Constants.RED;

                Actor segment = new Actor();
                segment.SetPosition(position);
                segment.SetVelocity(velocity);
                segment.SetText(text);
                segment.SetColor(color);
                _segments.Add(segment);
            }
        }

        //ublic void AddBody()
    }
}