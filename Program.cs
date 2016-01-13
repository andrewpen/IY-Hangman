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
            //GO HERE
            Console.WriteLine("Hello World");
            string input = Console.ReadLine();
            
            for (int i = 0; i < 10; (i)++)
            {
                Console.WriteLine("The number is: " + i);
            }
            
            if (input == "Hi")
            {
                // Do this if true    
                Console.WriteLine("Hello Back to you!");
            }
            else 
            {
                // Do this if false
                Console.WriteLine("You did not say Hi!");
            }
        }
    }
}
