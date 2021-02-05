using System;

namespace MultiplesOfThreeAndFive
{
    class MainClass
    {
        const int number = 1000;
        public static void Main(string[] args)
        {
            int total = 0;

            for (int i = 1; i < number; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    total += i;
                }
            }

            Console.WriteLine(total);
        }
    }
}
