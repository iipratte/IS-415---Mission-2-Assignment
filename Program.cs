using System;

namespace DiceSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the dice throwing simulator!\n");
            Console.WriteLine("How many dice rolls would you like to simulate?");
            int rollCount = int.Parse(Console.ReadLine());

            Roller r = new Roller();

            int[] resultsArray = r.RollSimulator(rollCount);

            Console.WriteLine("DICE ROLLING SIMULATION RESULTS");
            Console.WriteLine("Each \"*\" represents 1% of the total number of rolls.");
            Console.WriteLine("Total number of rolls = " + rollCount);

            for (int i = 2; i <= 12; i++)
            {
                double percentage = ((double)resultsArray[i] / rollCount) * 100;
                int asterisksCount = (int)Math.Round(percentage);
                Console.WriteLine(i + ": " + new string('*', asterisksCount));
            }

            Console.WriteLine("\nThank you for using the dice throwing simulator. Goodbye!\n");
        }
    }

}