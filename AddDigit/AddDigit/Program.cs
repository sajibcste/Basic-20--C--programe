using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddDigit
{
    class Program
    {
        static void Main(string[] args)
        {
            int number, temp, sum = 0, remainder;
            Console.WriteLine("Program to add digits of a Number");
            Console.WriteLine("Enter the Number for which you want to sum up the digits..");
            number = Convert.ToInt32(Console.ReadLine());
            temp = number;
            while (temp != 0)
            {
                remainder = temp%10;
                sum = sum + remainder;
                temp = temp/10;
            }
            Console.WriteLine("Sum of the The digit for number: {0} is sum:{1} ",number,sum);
            Console.ReadLine();
            Console.ReadLine();

        }
    }
}
