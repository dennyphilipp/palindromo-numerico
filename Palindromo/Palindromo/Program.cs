using System;
using System.Linq;

namespace Palindromo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input max value numeric...");
            string value = Console.ReadLine();
            int.TryParse(value, out int numeric);
            for (int i = 0; i <= numeric; i++)
            {
                for (int j = 0; j <= numeric; j++)
                {
                    string multiplier = (i * j).ToString();
                    var reverse = multiplier.Reverse().ToArray();
                    string result = string.Join(string.Empty, reverse);

                    if (multiplier == result)
                        Console.WriteLine($"Palindromo {i} * {j} = {multiplier}");
                }
            }
        }
    }
}
