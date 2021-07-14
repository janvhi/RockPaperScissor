using System;

namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            bool continuegame = false;
            Random r = new Random();
            int computerChoice;
            do
            {
                Console.WriteLine("\nDo you choose rock,paper or scissors");
                string userChoice = Console.ReadLine();
                computerChoice = r.Next(3);
                if (userChoice.ToLower().Equals("rock") || userChoice.ToLower().Equals("paper") || userChoice.ToLower().Equals("scissors"))
                {
                    if (computerChoice == 1)
                    {
                        ComputerChoicePaper(userChoice);
                    }
                    else if (computerChoice == 2)
                    {
                        ComputerChoicePaper(userChoice);
                    }
                    else if (computerChoice == 3)
                    {
                        ComputerChoicePaper(userChoice);
                    }
                }
                else
                {
                    Console.WriteLine("\nInvalid Input !!! please enter valid input, rock paper scissors");
                }
                Console.WriteLine("\nDo you  want to continue? y/n");
                var enteredk = Console.ReadKey();

                continuegame = enteredk.Key.ToString().ToLower() == "y";
            } while (continuegame);
        }

        public static void ComputerChoicePaper(string userSelection)
        {
            if (userSelection.Equals("rock") || userSelection.Equals("scissors"))
            {
                Console.WriteLine("\nComputer Choice paper");

                Console.WriteLine("You won!! Worray");

            }
            else if (userSelection.Equals("paper"))
            {
                Console.WriteLine("\nComputer Choice {0} as well its, a draw :P", userSelection);
            }
        }
        public void ComputerChoiceRock(string userSelection)
        {
            if (userSelection.Equals("paper") || userSelection.Equals("scissors"))
            {
                Console.WriteLine("\nComputer Choice rock");
                Console.WriteLine("\nYou lost!! Computer won");

            }
            else if (userSelection.Equals("rock"))
            {
                Console.WriteLine("\nComputer Choice {0} as well its, a draw :P", userSelection);
            }
        }
        public void ComputerChoiceScissors(string userSelection)
        {
            Console.WriteLine("\nComputer Choice scissors");
            if (userSelection.Equals("rock"))
            {
                Console.WriteLine("\nYou won!! Worray");

            }
            else if (userSelection.Equals("paper"))
            {
                Console.WriteLine("\nYou lost!! Computer won");

            }
            else if (userSelection.Equals("scissors"))
            {
                Console.WriteLine("\nComputer Choice {0} as well its, a draw :P", userSelection);
            }
        }
    }
}
