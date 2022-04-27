using System;

namespace MethodsWithLoopsAndConditionals
{
    class Program
    {
        static void Main(string[] args)
        {
            FullGame.Game();
        }
    }

    public class FullGame
    {
        public static void Game()
        {
            var r = new Random();
            var favNumber = r.Next(1, 100);
            int favNumber2 = 33;
            int i = 1;
            do
            {
                Console.WriteLine("Favorite Number Game! LVL 1 of 2 - Guess my favorite number (between 1 and 100) in 10 attempts");
                Console.WriteLine($"This is attempt number: {i} \n");
                var userInput = int.Parse(Console.ReadLine());


                if (userInput == favNumber2)
                {
                    Console.WriteLine("***Congrats, you guessed correctly! You passed LVL 1!***\n");
                    Console.WriteLine("\nDo you want to play LVL 2? - Yes or No? ");
                    var userInput2 = Console.ReadLine();
                    if (userInput2 == "Yes" || userInput2 == "yes" || userInput2 == "YES" || userInput2 == "y" || userInput2 == "Y")
                    {
                        Console.WriteLine();
                        FullGame.GameLVL2();
                        break;
                    }
                    else
                    {
                        Console.WriteLine("\nThank you for playing, TAKE CARE!");
                        Console.ReadKey();
                        break;
                    }
                }
                else if (userInput > favNumber2)
                {
                    Console.WriteLine("Your choice was too high, please try again!\n");
                }
                else if (i == 10)
                {
                    Console.WriteLine("Oh no, you loose! GAME OVER\n");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("Your choice was too low, please try agian.\n");
                }

                i++;
            }
            while (i < 11);
        }
        public static void GameLVL2()
        {
            var r = new Random();
            var favNumber = r.Next(1, 1000);
            int favNumber2 = 617;
            int i = 1;
            do
            {
                Console.WriteLine("Favorite Number Game! Welcome to LVL 2 of 2: Guess my favorite number (between 1 and 1,000) in 5 attempts");
                Console.WriteLine($"This is attempt number: {i} \n");
                var userInput = int.Parse(Console.ReadLine());

                if (userInput == favNumber2)
                {
                    Console.WriteLine("\n***Congrats, you guessed correctly! You won the game!***\n");
                    break;
                }
                else if (i == 5)
                {
                    Console.WriteLine("Oh no, you loose! GAME OVER\n");
                    Console.ReadKey();
                    break;
                }
                else if (userInput > favNumber2)
                {
                    Console.WriteLine("Your choice was too high, please try again!\n");
                }
                else
                {
                    Console.WriteLine("Your choice was too low, please try agian.\n");
                }

                i++;
            }
            while (i < 6);
        }
    }

}
