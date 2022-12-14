using Unit05.Game.Casting;
using Unit05.Game.Services;


namespace Unit05.Game.Scripting
{
    /// <summary>
    /// <para>An input action that controls the snake.</para>
    /// <para>
    /// The responsibility of ControlActorsAction is to get the direction and move the snake's head.
    /// </para>
    /// </summary>
    public class ControlActorsAction : Action
    {
        private KeyboardService _keyboardService;
        private Point _direction = new Point(Constants.CELL_SIZE, 0);
        private Point _direction2 = new Point(Constants.CELL_SIZE, 0);


        /// <summary>
        /// Constructs a new instance of ControlActorsAction using the given KeyboardService.
        /// </summary>
        public ControlActorsAction(KeyboardService keyboardService)
        {
            this._keyboardService = keyboardService;
        }
        /// <inheritdoc/>
        public void Execute(Cast cast, Script script)
        {
            // ----------------- first snake -----------------
            // left
            if (_keyboardService.IsKeyDown("a"))
            {
                _direction = new Point(-Constants.CELL_SIZE, 0);
                
            }
            // right
            else if (_keyboardService.IsKeyDown("d"))
            {
                _direction = new Point(Constants.CELL_SIZE, 0);
            }
            // up
            else if (_keyboardService.IsKeyDown("w"))
            {
                _direction = new Point(0, -Constants.CELL_SIZE);
            }
            // down
            else if (_keyboardService.IsKeyDown("s"))
            {
                _direction = new Point(0, Constants.CELL_SIZE);
            }

            // ----------------- second snake -----------------
            // left
            if (_keyboardService.IsKeyDown("j"))
            {
                _direction2 = new Point(-Constants.CELL_SIZE, 0);
            }
            // right
            else if (_keyboardService.IsKeyDown("l"))
            {
                _direction2 = new Point(Constants.CELL_SIZE, 0);
            }
            // up
            else if (_keyboardService.IsKeyDown("i"))
            {
                _direction2 = new Point(0, -Constants.CELL_SIZE);
            }
            // down
            else if (_keyboardService.IsKeyDown("k"))
            {
                _direction2 = new Point(0, Constants.CELL_SIZE);
            }
            Snake snake2 = (Snake)cast.GetFirstActor("secondSnake");
            Snake snake = (Snake)cast.GetFirstActor("snake");
            snake.TurnHead(_direction);
            snake2.TurnHead(_direction2);

        }

    public static implicit operator ControlActorsAction(KeyboardService v)
    {
      throw new System.NotImplementedException();
    }
  }
}