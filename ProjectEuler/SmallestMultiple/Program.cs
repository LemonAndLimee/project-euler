using System;

namespace SmallestMultiple
{
    class MainClass
    {
        const int upperLim = 10;
        public static void Main(string[] args)
        {
            int number = 0;
            bool solved = false;
            while (!solved)
            {
                Console.WriteLine(number);
                number++;
                solved = true;
                for (int i = 1; i <= upperLim; i++)
                {
                    if (number % i != 0)
                    {
                        solved = false;
                    }
                }
            }
            Console.WriteLine(number);
        }
    }
}
