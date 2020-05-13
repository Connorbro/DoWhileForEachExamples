using System;

namespace CleanCodingInC
{
    class Program
    {
        static void Main(string[] args)
        {
            string secretWord = "Tiger";
            string guess = "";
            int guessCount = 0;
            int guessLimit = 3;
            bool outOfGuesses = false;


            while(guess != secretWord)
            {
                if (guessCount <= guessLimit)
                {
                    Console.Write("Enter guess: ");
                    guess = Console.ReadLine();
                    guessCount++;

                }
                
            }
            Console.Write($"You guessed the word {secretWord}, You win!");

           
        }
    }
}
