﻿using System;

namespace CleanCodingInC
{
    class Program
    {
        static void Main(string[] args)
        {
            string secretWord = "Tiger";
            string guess = "";

            while(guess != secretWord)
            {
                Console.Write("Enter guess: ");
                guess = Console.ReadLine();
            }
            Console.Write($"You guessed the word {secretWord}, You win!");

           
        }
    }
}
