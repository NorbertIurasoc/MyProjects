using System;

namespace RockScissorsPaper_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Rock Scissors Paper Game\n");

            string[] module = { "ROCK", "SCISSORS", "PAPER" };

            string GameMode = "";
            int result1 = 0;
            int result2 = 0;

            //ROCK > SCISSORS
            //SCISSORS > PAPER
            //PAPER > ROCK

            Console.WriteLine("ROCK");
            Console.WriteLine("SCISSORS");
            Console.WriteLine("PAPER\n");

            Console.WriteLine("Who reach three wined rounds, won the game!\n");
            do
            {
                Console.Write("Enter what you want to choose: ");

                GameMode = Console.ReadLine();

                Random adversar = new Random();
                int adv = adversar.Next(module.Length);
                Console.WriteLine($"The adversar choosed: {module[adv]}");

                if (GameMode == "ROCK" && module[adv] == "SCISSORS")
                {
                    result1++;
                    Console.WriteLine($"RESULT: {result1} - {result2}\n");
                }
                else if (GameMode == "ROCK" && module[adv] == "PAPER")
                {
                    result2++;
                    Console.WriteLine($"RESULT: {result1} - {result2}\n");
                }
                else if (GameMode == "ROCK" && module[adv] == "ROCK")
                {
                    Console.WriteLine($"RESULT: {result1} - {result2}\n");
                }
                else if (GameMode == "SCISSORS" && module[adv] == "PAPER")
                {
                    result1++;
                    Console.WriteLine($"RESULT: {result1} - {result2}\n");
                }
                else if (GameMode == "SCISSORS" && module[adv] == "ROCK")
                {
                    result2++;
                    Console.WriteLine($"RESULT: {result1} - {result2}\n");
                }
                else if (GameMode == "SCISSORS" && module[adv] == "SCISSORS")
                {
                    Console.WriteLine($"RESULT: {result1} - {result2}\n");
                }
                else if (GameMode == "PAPER" && module[adv] == "ROCK")
                {
                    result1++;
                    Console.WriteLine($"RESULT: {result1} - {result2}\n");
                }
                else if (GameMode == "PAPER" && module[adv] == "SCISSORS")
                {
                    result2++;
                    Console.WriteLine($"RESULT: {result1} - {result2}\n");
                }
                else if (GameMode == "PAPER" && module[adv] == "PAPER")
                {
                    Console.WriteLine($"RESULT: {result1} - {result2}\n");
                }
            }
            while (result1 <= 2 && result2 <= 2);

            if (result1 > result2)
            {
                Console.WriteLine("-----------------------------");
                Console.WriteLine("| CONGRATULATIONS! YOU WON! |");
                Console.WriteLine("-----------------------------");
            }
            else
            {
                Console.WriteLine("------------------------------------------");
                Console.WriteLine("| This time the opponent was more lucky! |");
                Console.WriteLine("------------------------------------------");
            }

            Console.ReadKey();
        }
    }
}
