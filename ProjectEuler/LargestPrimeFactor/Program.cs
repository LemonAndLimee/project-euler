using System;

namespace LargestPrimeFactor
{
    class MainClass
    {
        //const double number = 600851475143;
        const double number = 600851475143;
        public static void Main(string[] args)
        {
            bool solved = false;
            double currentNumber = number;
            double numberToTry = 2;

            while (!solved && numberToTry < currentNumber)
            {
                Console.WriteLine("{0} {1}", currentNumber, numberToTry);
                if (currentNumber % numberToTry == 0)
                {
                    if (currentNumber / numberToTry > numberToTry)
                    {
                        currentNumber = currentNumber / numberToTry;
                    }
                    else
                    {
                        currentNumber = numberToTry;
                    }
                }

                if (currentNumber % numberToTry != 0)
                {
                    numberToTry++;
                }
            }

            Console.WriteLine(numberToTry);
        }
    }
}
