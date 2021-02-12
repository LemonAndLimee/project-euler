using System;

namespace LargestPalindromeProject
{
    class MainClass
    {
        const int digits = 3;
        public static void Main(string[] args)
        {
            int maxCap = (int)Math.Pow(10, digits) - 1;
            int minCap = (int)Math.Pow(10, digits - 1) - 1;
            int result = 0;
            int x = maxCap;
            while (x > minCap)
            {
                int y = maxCap;
                while (y > minCap)
                {
                    int product = x * y;
                    bool isPalindrome = IsPalindrome(product);
                    if (isPalindrome)
                    {
                        if (product > result)
                        {
                            result = product;
                            Console.WriteLine("{0} {1} x {2}", product, x, y);
                        }
                    }
                    y--;
                }
                x--;
            }
        }

        static bool IsPalindrome(int input)
        {
            bool palindrome = true;
            string number = input.ToString();
            for (int i = 0; i < (number.Length/2); i++)
            {
                if (number[i] != number[number.Length - (1 + i)])
                {
                    palindrome = false;
                }
            }
            return palindrome;
        }
    }
}
