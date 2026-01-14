using System;

Console.WriteLine("Welcome to the dice throwing simulator!\n");
Console.WriteLine("How many dice rolls would you like to simulate?");
int rollCount = int.Parse(Console.ReadLine());

int[] rolls = new int[13];

int roll1;
int roll2;
int rollTotal;

Random rnd = new Random();

for (int i = 0; i < rollCount; i++)
{
    roll1 = rnd.Next(1, 7);
    roll2 = rnd.Next(1, 7);
    rollTotal = roll1 + roll2;

    rolls[rollTotal]++;
}

Console.WriteLine("DICE ROLLING SIMULATION RESULTS");
Console.WriteLine("Each \"*\" represents 1% of the total number of rolls.");
Console.WriteLine("Total number of rolls = " + rollCount);

for (int i = 2; i <= 12; i++)
{
    double percentage = ((double)rolls[i] / rollCount) * 100;
    int asterisksCount = (int)Math.Round(percentage);
    Console.WriteLine(i + ": " + new string('*', asterisksCount));
}

Console.WriteLine("\nThank you for using the dice throwing simulator. Goodbye!\n");