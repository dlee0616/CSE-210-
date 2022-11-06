using System.Collections.Generic;


namespace Greed.Casting
{
 

    public class Color
    {
        private int _red = 0;
        private int _yellow = 0;
        private int _purple = 0;
        private int _alpha = 255; 
      
        //instance of a new color 
        public Color(int red, int green, int blue)
        {
            this._red = red;
            this._green = green;
            this._purple = purple;
        }

   
        /// Gets the color's alpha value.
        public int GetAlpha()
        {
            return _alpha;
        }

   
        /// Gets the color's blue value.

        public int GetPurple()
        {
            return _purple;
        }


        /// Gets the color's red value.
        public int GetRed()
        {
            return _red;
        }

 
        /// Gets the color's yellow value.
        public int GetYellow()
        {
            return _yellow;
        }

    }
}