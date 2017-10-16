using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            int reverse=0, n,a;
            Console.WriteLine("Please Enter your digit");
            a = int.Parse(Console.ReadLine());
            n = a;
            while (n != 0)
            {
                reverse = reverse*10;
                reverse = reverse + n%10;
                n = n/10;

            }

            if (reverse == a)
            {
                Console.WriteLine("This number is plaindrome");
            }
            else
            {
                Console.WriteLine("This number is not plaindrome");
            }
            Console.ReadKey();
        }
    }
}
