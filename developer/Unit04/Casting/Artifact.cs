namespace Greed.Casting
{
    
    public class Artifact : Actor
    {
        private string _message = "SCORE : " _score;

        /// returns the message
        public string GetMessage()
        {
            return _message;
        }

       //sets message to original value
        public void SetMessage(string message)
        {
            this._message = message;
        }
    }
}