using System;
using System.Linq;

namespace Palindromo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input minimum value numeric...");
            string value = Console.ReadLine();
            int.TryParse(value, out int minimumNumeric);

            Console.WriteLine("Input max value numeric...");
            value = Console.ReadLine();
            int.TryParse(value, out int maxNumeric);

            for (int i = minimumNumeric; i <= maxNumeric; i++)
            {
                for (int j = minimumNumeric; j <= maxNumeric; j++)
                {
                    string multiplier = (i * j).ToString();
                    var reverse = multiplier.Reverse().ToArray();
                    string result = string.Join(string.Empty, reverse);

                    if (multiplier == result)
                        Console.WriteLine($"Palindromo {i} * {j} = {multiplier}");
                }
            }
            Console.WriteLine();
        }
    }
}
