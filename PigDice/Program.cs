using System;
using System.Security.Cryptography;

namespace PigDice
{
    class Program
    {
        static void Main(string[] args)
        {
            
            bool over = false;

            double score = 0;
            double currentScore = 0;

            for(var i = 0; i <= 2000000000; i++)
            {
                currentScore = 0;
                while (!over)
                {
                    var roll = RandomNumberGenerator.GetInt32(1, 7);
                    if (roll == 1)
                        break;
                    else
                        currentScore += roll;
                }
                if (currentScore > score)
                {
                    score = currentScore;
                    Console.WriteLine(score);
                }
            }

            Console.WriteLine(score);
        }
    }
}
