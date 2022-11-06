namespace Greed.Casting
{
  
 
    public class coordinate
    {
        private int _x = 0;
        private int _y = 0;

        //new instance of x and y
        public Point(int x, int y)
        {
            this._x = x;
            this._y = y;
        }

        /// <summary>
        /// Adds the given point to this one by summing the x and y values.
        /// </summary>
        /// <param name="other">The point to add.</param>
        /// <returns>The sum as a new Point.</returns>
        public coordinate Add(coordinate other)
        {
            int x = this._x + other.GetX();
            int y = this._y + other.GetY();
            return new coordinate(x, y);
        }

        public bool Equals(coordinate other)
        {
            return this._x == other.GetX() && this._y == other.GetY();
        }
        //return x coorindate 
        public int GetX()
        {
            return _x;
        }

       //return the y coordinate 
        public int GetY()
        {
            return _y;
        }

       //return instance of coordinate 
        public coordinate Scale(int factor)
        {
            int x = this._x * factor;
            int y = this._y * factor;
            return new coorindate(x, y);
        }
    }
}