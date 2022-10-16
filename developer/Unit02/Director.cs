using System;

namespace Hilo
{
    class Director
    {
        private void Director(string[] args)
        {
            //summon score
            private int _score = 300;
            //summon deck
            private Deck _deck = new Deck();
            //summon player
            private Player _player = new Player();
        }
        /* Execute game process of hi/lo */
        public void startGame()
        {
            // Loop in here to direct game flow
            bool gameOver = false;
            while (!gameOver)
            {
                // Pull a card 
                var random = new Random();
                string firstCard = random.Next(_deck.Count);
                //string random = _deck[firstCard];
                Console.WriteLine(string.Format("The card is:", firstCard));
                // Ask hi/lo
                Console.WriteLine("Higher or lower [H/L]");
                string playerGuess = Console.ReadLine();
                // Reveal next card
                var nextRandom = new Random();
                string nextCard = nextRandom.Next(_deck.Count);
                //string nextCard = _deck[nextCard];
                Console.WriteLine(string.Format("The card is:", nextCard));
                // Edit points
                if (playerGuess = "H" && nextCard > firstCard)
                {
                    int _score = _score + 100;
                    return _score;
                }
                else if (playerGuess = "L" && nextCard < firstCard)
                {
                    int _score = _score - 75; 
                    return _score; 
                }
                // Prompt play again?
                Console.WriteLine("Play again?('Y/N')");
                string answer = Console.ReadLine();
                if (answer = "Y")
                {
                startGame();
                }
                else if (answer = "N")
                {
                    break;
                }
                
            }
        }
    }
}
