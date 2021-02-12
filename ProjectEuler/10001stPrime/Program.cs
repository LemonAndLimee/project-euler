using System;

namespace stPrime
{
    class MainClass
    {
        const int n = 10001;
        public static void Main(string[] args)
        {
            int turn = -1;
            int primeCount = 4;
            int currentNumber = 11;

            while (primeCount < n)
            {
                if (turn > -1)
                {
                    if ((turn - 1) % 4 == 0 || turn == 1)
                    {
                        currentNumber += 4;
                    }
                    else
                    {
                        currentNumber += 2;
                    }
                }
                turn++;

                bool prime = true;
                for (int i = 2; i < currentNumber; i++)
                {
                    if (currentNumber % i == 0)
                    {
                        prime = false;
                    }
                }
                if (prime)
                {
                    primeCount++;
                }
            }

            Console.WriteLine(currentNumber);
        }
    }
}
