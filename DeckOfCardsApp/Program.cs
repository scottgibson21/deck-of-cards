using System;
using System.Collections.Generic;
using System.Threading;

namespace DeckOfCardsApp
{
    class Program
    {

        static readonly List<string> _validInputs = new List<string> {"1", "2", "3", "4"};

        static void Main(string[] args)
        {
            var deck = new DeckOfCards();

            string input = null;

            while(input != "4")
            {
                Console.WriteLine("---Deck of Cards APP---");
                Console.WriteLine("\nWhat would you like to do?");
                Console.WriteLine("1. Print all of the cards");
                Console.WriteLine("2. Deal top 5 cards");
                Console.WriteLine("3. Shuffle Deck");
                Console.WriteLine("4. Quit");

                Console.Write("\nEnter your selection: ");

                input = Console.ReadKey().KeyChar.ToString();

                while (!_validInputs.Contains(input))
                {
                    Console.Write("Error: Invalid Input.  Please enter a valid selection (1, 2, or 3)");
                    Console.WriteLine("Enter your selection: ");
                    input = Console.ReadKey().KeyChar.ToString();
                }

                Console.Clear();

                switch(input)
                {
                    case "1":
                        deck.PrintCards();
                        Console.WriteLine("\nPRESS ANY KEY TO CONTINUE");
                        Console.ReadKey();
                        break;
                    case "2":
                        deck.DealFiveCards();
                        Console.WriteLine("\nPRESS ANY KEY TO CONTINUE");
                        Console.ReadKey();
                        break;
                    case "3":
                        deck.ShuffleCards();
                        Console.WriteLine("\nPRESS ANY KEY TO CONTINUE");
                        Console.ReadKey();
                        break;
                    case "4":
                        DisplayExitAnimation();
                        break;
                    default:
                        throw new Exception($"Invalid input encountered: {input}");
                }

                Console.Clear();
            }
        }

        static private void DisplayExitAnimation()
        {
            List<string> animationChars = new List<string> { "/", "-", @"\" };

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < animationChars.Count; j++)
                {
                    Console.WriteLine($"Quiting {animationChars[j]}");
                    Thread.Sleep(250);
                    Console.Clear();
                }
            }
        }
    }
}
