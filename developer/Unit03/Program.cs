using System;
using System.Collections.Generic;
namespace Jumper
{
    // The program must include a README file.
// The program must include class and method comments.
// The program must have at least four classes.
// The program must remain true to game play described in the overview.
// namespace Jumper 
    public class process
    {
       public List<string> answerKey;
        //static void answer()
        //{
            //List <string> answerKey = new List<string> ();
            //answerKey.Add("Donkey");
            //answerKey.Add("apple");
            //answerKey.Add("infiniti");
            //answerKey.Add("sandraBullock");
        //}
         //static void summon()
         //{
            //Director director = new Director();
           
         //}
        static void parachute()
        {
                Console.WriteLine("\n      ---");
                Console.WriteLine("    [-----]");
                Console.WriteLine("     [---]");
                Console.WriteLine("       |");
                Console.WriteLine("       O");
                Console.WriteLine("      /|\\");
                Console.WriteLine("      / \\");
        }
        static void match()
        {   

        }
        static void Main(string[] args)
        {
            //geerate word list
            
        
            var answerKey = new List<string> {"apple", "infiniti", "peanutbutter", "microsoft", "kimchi"};
            bool gameOver = false; 
            //pick random word 
            Random random = new Random();
            int index = random.Next(answerKey.Count);
            string secretWord = answerKey[index];            
            string underscore = "";
            foreach(char c in answerKey[index])
                    {
                        underscore = underscore + "_ ";
                    }
            char[] dashes = underscore.ToCharArray();
            
            // Game loop
            while(!gameOver)
            {
                //get guess
                List<char> guessedLetters = new List<char>();
                Console.WriteLine("\nGuess a letter (a - z) ");
                char guess = Console.ReadLine();

                // Check if letter was already guessed
                // Continue prompting for input as long as the input is invalid!
                // First check if the input is valid
                bool alreadyGuessed = letterWasGuessed(guess, guessedLetters);
                while (alreadyGuessed) {
                    Console.WriteLine("Letter already guessed! Guess again (a - z) ");
                    guess = console.ReadLine();
                    // Check again if the input is valid. Continue to check as long as
                    // input is invalid
                    alreadyGuessed = letterWasGuessed(guess, guessedLetters);
                }

                Console.Write(dashes);
                parachute();
            
                bool correctGuess = checkGuess(guess, secretWord);
                // check the letter against every letter in the secret word
                if (correctGuess) {
                    
                }
                // They got the guess wrong
                else 
                {
                    
                }
                // Add guessed letter to the list so they don't get it wrong or right again
                guessedLetters.Add(guess);
            }
        }

        // Ensure the guess matches a letter in the secret word
        static bool checkGuess(char guess, string key) {
            // check if the guess was correct
            foreach(char item in key) {
                if (guess == item){
                    return true; 
                }
            }
            // Letter was not found in the secret word
            return false;
        }

        // Ensure the letter which was guessed has not already been guessed
        static bool letterWasGuessed(char guess, List<char> guesses) {
            
            foreach(char item in guesses) {
                if (guess == item){
                    return false; 
                }
            }
            // no issues, return true!
            return true;
        }
    }
}
