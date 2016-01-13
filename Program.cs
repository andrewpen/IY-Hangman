using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;

namespace Hangman
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Introduction Statement
            Console.WriteLine("Welcome to Hangman");
            
            // Pick a Word
            string wordToGuess = GetWord();
            StringBuilder displayToPlayer = new StringBuilder(string.Empty.PadRight(wordToGuess.Length, '-'));
            
            bool continueGame = true;
            
            while (continueGame)
            {
                // Draw the Scene
                DrawScene(displayToPlayer.ToString());
                
                // Ask the person to guess a letter and store it
                Console.WriteLine("What is your guess");
                string guess = Console.ReadLine();
                
                // If that letter is in the word, show that letter - then ask again?
                if (wordToGuess.Contains(guess[0]))
                {
                    // They guessed correctly
                    Console.WriteLine("That's in the word!");
                    
                    // Update the word we show the user to show the guessed letter
                    for (var i = 0; i < wordToGuess.Length; i++)
                    {
                        if (wordToGuess[i] == guess[0])
                        {
                            displayToPlayer[i] = wordToGuess[i];
                        }
                    }
                }
                else
                {
                    // They guessed incorrectly
                    // Otherwise that letter isn't in the word, we add a piece to hangman
                    Console.WriteLine("That's not in the word :(");
                }
                
                // Check if they win
                // They win IF the hidden word is equal to the guessed word, end the game
                if (wordToGuess == displayToPlayer.ToString())
                {
                    Console.WriteLine("You guessed it!");
                    continueGame = false;
                }
                // They lost IF they have 5 bad guesses
            } // Go back up to "Draww the Scene"
        }
        
        private static string GetWord()
        {
            return "acre";
        }
        
        private static void DrawScene(string displayToPlayer)
        {
            Console.WriteLine(displayToPlayer);
        }
    }
}
