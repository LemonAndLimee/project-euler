using System;

namespace SumSquareDifference
{
    class MainClass
    {
        const int limit = 100;
        public static void Main(string[] args)
        {
            double sumOfSquares = 0, squareOfSum, difference;

            /*for (int i = 1; i <= limit; i++)
            {
                sumOfSquares += Math.Pow(i, 2);
            }

            double total = 0;
            for (int i = 1; i <= limit; i++)
            {
                total += i;
            }
            squareOfSum = Math.Pow(total, 2);*/

            double total = 0.5 * limit * (limit + 1);
            squareOfSum = Math.Pow(total, 2);

            sumOfSquares = (limit * (limit + 1) * ((2 * limit) + 1)) / 6;

            difference = squareOfSum - sumOfSquares;
            Console.WriteLine(difference);
        }
    }
}
