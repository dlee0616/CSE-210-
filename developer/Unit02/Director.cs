using System;

namespace Hilo
{
    class Director
    {
        public Director()
        {
            //summon score
            //int _score = 300;
            //summon deck
            Deck _deck = new Deck();
            //summon player
            Player _player = new Player();
        }
        /* Execute game process of i/lo */
        public void startGame()
        {
            // Loop in here to direct game flow
            int _score = 300;
            bool gameOver = false;
            while (!gameOver)
            {
                // Pull a card 
                Random random = new Random();
                int firstCard = _deck.Next(1,13);
                //string _random = _deck[firstCard];
                Console.WriteLine(string.Format("The card is : " + firstCard));
                // Ask hi/lo
                Console.WriteLine("Higher or lower [H/L]");
                string playerGuess = Console.ReadLine();
                // Reveal next card
                Random nextRandom = new Random();
                int nextCard = nextRandom.Next(1,13);
                //string nextCard = _deck[nextCard];
                Console.WriteLine(string.Format("The new card was :" + nextCard));
                // Edit points
                if (playerGuess == "H" && nextCard > firstCard)
                {
                    _score = _score + 100;
                    Console.WriteLine("Your score is :" + _score);
                }

                else if (playerGuess == "H" && nextCard < firstCard);

                {
                    _score = _score - 75; 
                    Console.WriteLine("Your score is :" + _score);
                }
                  
                else if (playerGuess == "L" && nextCard < firstCard)
                {
                    _score = _score + 100;
                    Console.WriteLine("Your score is :" + _score);
                }
                else if (playerGuess == "L" && nextCard > firstCard)
                {
                    _score = _score - 75; 
                    Console.WriteLine("Your score is :" + _score);
                }
                else if (nextCard == firstCard)
                {
                    Console.WriteLine("Your cards were the same");
                }
                // Prompt play again?
                Console.WriteLine("Play again?('Y/N')");
                string answer = Console.ReadLine();
                if (answer == "N")
                {
                    gameOver = true;
                }
                
            }
        }
    }
}
