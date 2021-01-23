using System;
using System.Runtime.InteropServices;

namespace NumberBaseConverter
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string conversionType, valueToBeConverted;
            Console.Write("Enter conversion type in form AB: ");
            conversionType = Console.ReadLine().ToUpper();
            Console.Write("Enter value to be converted: ");
            valueToBeConverted = Console.ReadLine();

            ProcessConversion(conversionType, valueToBeConverted);
        }
        static void ProcessConversion(string type, string value)
        {
            if (type[1] == 'D')
            {
                int result = 0;
                if (type[0] == 'B')
                {
                    result = BinaryToDenary(value);
                }
                else if (type[0] == 'H')
                {
                    result = HexToDenary(value);
                }
                Console.WriteLine(result);
            }
            else
            {
                string result = "";
                if (type[0] == 'D')
                {
                    int denaryValue = int.Parse(value);
                    if (type[1] == 'H')
                    {
                        result = DenaryToHex(denaryValue);
                    }
                    else if (type[1] == 'B')
                    {
                        result = DenaryToBinary(denaryValue);
                    }
                }
                else if (type[0] == 'H')
                {
                    result = HexToBinary(value);
                }
                else if (type[0] == 'B')
                {
                    result = BinaryToHex(value);
                }
                Console.WriteLine(result);
            }
        }

        static string DenaryToHex(int number)
        {
            string hex = "";

            int currentValue = number;
            while (currentValue != 0)
            {
                int remainder = currentValue % 16;
                if (remainder < 10)
                {
                    hex = remainder.ToString() + hex;
                }
                else
                {
                    hex = (char)(remainder + 'A' - 10) + hex;
                }
                currentValue = currentValue / 16;
            }

            return hex;
        }
        static string DenaryToBinary(int number)
        {
            string binary = "";
            int currentNumber = number, remainder;
            while ((currentNumber / 2) > 0)
            {
                remainder = currentNumber % 2;
                binary = remainder.ToString() + binary;
                currentNumber = currentNumber / 2;
            }
            remainder = currentNumber % 2;
            binary = remainder.ToString() + binary;
            return binary;
        }

        static int BinaryToDenary(string binary)
        {
            int denary = 0, bits;
            bits = binary.Length;

            for (int i = 0; i < bits; i++)
            {
                if (binary[i] == '1')
                {
                    int value = (int)Math.Pow(2, bits - (i + 1));
                    denary += value;
                }
            }

            return denary;
        }
        static int HexToDenary(string hex)
        {
            int denary = 0;
            int counter = 1;
            for (int i = hex.Length-1; i >= 0; i--)
            {
                int charValue = 0;
                if (hex[i] >= 'A')
                {
                    charValue = (int)((hex[i] - 'A')+10);
                }
                else
                {
                    charValue = int.Parse(hex[i].ToString());
                }
                denary += (charValue * counter);
                counter *= 16;
            }
            return denary;
        }

        static string HexToBinary(string hex)
        {
            string binary;
            int denary;
            denary = HexToDenary(hex);
            binary = DenaryToBinary(denary);
            return binary;
        }
        static string BinaryToHex(string binary)
        {
            string hex;
            int denary;
            denary = BinaryToDenary(binary);
            hex = DenaryToHex(denary);
            return hex;
        }
    }
}
