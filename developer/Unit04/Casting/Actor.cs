using System;


namespace Greed.Casting
{
   
    public class Actor
    {
        private string _text = "";
        //set font size
        private int _fontSize = 20;

        //set actor's initial position 
        private Point _position = new Point(0, 0);
        private Point _velocity = new Point(0, 0);

        //set the actor's color to yellow
        private Color _color = new Color(255, 255, 0); 
        
        /// Create instance of an actor 
       
        public Actor()
        {
        }

        /// returns the color.
        public Color GetColor()
        {
            return _color;
        }

        //return font size 
        public int GetFontSize()
        {
            return _fontSize;
        }

        //returns the position.
        public Point GetPosition()
        {
            return _position;
        }

        //get the text
        public string GetText()
        {
            return _text;
        }

       //get velocity
        public Point GetVelocity()
        {
            return _velocity;
        }

        //moves the actor 
        public void MoveNext(int maxX, int maxY)
        {
            int x = ((_position.GetX() + _velocity.GetX()) + maxX) % maxX;
            int y = ((_position.GetY() + _velocity.GetY()) + maxY) % maxY;
            _position = new Point(x, y);
        }

        //text size cant be 0
        public void SetFontSize(int fontSize)
        {
            if (fontSize<= 0)
            {
                throw new ArgumentException("fontSize must be greater than zero");
            }
            this._fontSize = fontSize;
        }

        /// position cant be null 
        public void SetPosition(Point position)
        {
            if (position == null)
            {
                throw new ArgumentException("position can't be null");
            }
            this._position = position;
        }
       
        /// color cant be null 
        public void SetColor(Color color)
        {
            if (color == null)
            {
                throw new ArgumentException("color can't be null");
            }
            this._color = color;
        }

        //text cant be null 
        public void SetText(string text)
        {
            if (text == null)
            {
                throw new ArgumentException("text can't be null");
            }
            this._text = text;
        }

        //velocity cant be null 
        public void SetVelocity(Point velocity)
        {
            if (velocity == null)
            {
                throw new ArgumentException("velocity can't be null");
            }
            this._velocity = velocity;
        }

    }
}