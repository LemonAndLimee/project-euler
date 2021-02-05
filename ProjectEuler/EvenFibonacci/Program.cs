using System;

namespace EvenFibonacci
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int number1 = 1;
            int number2 = 2;
            int currentValue = 0;
            int total = 2;

            while (number2 < 4000000)
            {
                currentValue = number1 + number2;
                number1 = number2;
                number2 = currentValue;

                if (number2 % 2 == 0)
                {
                    total += number2;
                }
            }
            Console.WriteLine(total);
        }
    }
}
