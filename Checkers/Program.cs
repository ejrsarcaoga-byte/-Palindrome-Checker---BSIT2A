using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checkers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out int number))
            {
                if (IsPalindrome(number))
                {
                    Console.WriteLine($"{number} is a palindrome");
                }
                else
                {
                    Console.WriteLine($"{number} is not a palindrome");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
            Console.WriteLine("\nPress Enter to exit");
            Console.ReadLine();
        }
        static bool IsPalindrome(int number)
        {
            string numStr = number.ToString();
            string reversed = "";

            for (int i = numStr.Length - 1; i >= 0; i--)
            {
                reversed += numStr[i];
            }

            return numStr == reversed;
        }
    }
}
