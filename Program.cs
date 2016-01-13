using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
                DrawScene();
                
                // Ask the person to guess a letter and store it
                Console.WriteLine("What is your guess");
                string guess = Console.ReadLine();
                
                // If that letter is in the word, show that letter - then ask again?
                
                // Otherwise that letter isn't in the word, we add a piece to hangman
                
                // Check if they win
                // They win IF the hidden word is equal to the guessed word, end the game
                // They lost IF they have 5 bad guesses
            } // Go back up to "Draww the Scene"
        }
        
        private static string GetWord()
        {
            var words = File.ReadAllLines(@"C:\projects\HangmanCrash\HangmanCrash\hangmanwords.txt");

            var r = new Random();
            var position = r.Next(words.Length);

            return words[position];
        }
        
        private static string DrawScene()
        {
            return true;
        }
    }
}
