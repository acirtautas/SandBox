using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GuessANumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Play(1, 10);
        }

        /**
         * Play game Gues A Number.
         **/
        private static void Play(int From, int To)
        {
            int number = Think(From, To);
            int guess = 0;
            int tries = 0;

            Console.WriteLine("Enter a number " + From + ".." + To);

            do {

                guess = Guess();
                tries++;

                if (number < guess)
                {
                    Console.WriteLine("try smaller");
                }

                if (number > guess)
                {
                    Console.WriteLine("try bigger");
                }

            } while (number != guess);

            Console.WriteLine("You win! (" + tries + " tries)");
            Console.ReadLine();
        }

        /**
         * Think a number in range From To.
         **/
        private static int Think(int From, int To)
        {
            int number = new Random().Next(From, To);

            return number;
        }

        /**
         * Guess a number.
         **/
        private static int Guess()
        {
            int guess = 0;

            guess = int.Parse(Console.ReadLine());

            return guess;
        }
    }
}
