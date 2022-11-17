using System;
// The program must include a README file.
// The program must include class and method comments.
// The program must have at least two classes.
// The program must remain true to game play described in the overview.

namespace Hilo
{
    class Program
    {

        static void Main(string[] args)
        {
            // summon starting score
            int _score = 300;
            // call deck
            Deck _deck = new Deck();

            bool gameOver = false;
            //begin game
            while (!gameOver)
            {
                // Pull initial card 
                Random random = new Random();
                int firstCard = _deck._cards[random.Next(_deck._cards.Count)];
                // int firstCard = _deck[random.Next(_deck.Count)];
                
                // Reveal card
                Console.WriteLine(string.Format("The card is : " + firstCard));
                
                // Ask hi/lo
                Console.WriteLine("Higher or lower [H/L]");
                string playerGuess = Console.ReadLine();
                
                // Reveal next card
                int nextCard = _deck._cards[random.Next(_deck._cards.Count)];
                
                //reveal next card
                Console.WriteLine(string.Format("The new card was :" + nextCard));
                
                // update points
                if (playerGuess == "H" && nextCard > firstCard)
                {
                    _score = _score + 100;
                    Console.WriteLine("Your score is :" + _score);
                }

                else if (playerGuess == "H" && nextCard < firstCard)

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
