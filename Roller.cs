using System;

namespace DiceSimulator
{
    public class Roller
    {
        public int[] RollSimulator(int rollCount)
        {
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

            return rolls;
        }
    }

}