using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int x,fact=1;
            Console.WriteLine("Enter a digit for factorial...");
            x = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= x; i++)
            {
                fact = fact*i;
            }
            Console.WriteLine("{0} Digit are factorial is:{1}",x,fact);
            Console.ReadKey();


        //     {
        //    Console.WriteLine("Enter a number");
        //    int number = Convert.ToInt32(Console.ReadLine());
        //    long fact = GetFactorial(number);
        //    Console.WriteLine("{0} factorial is {1}", number, fact);           
        //    Console.ReadKey();
        //}
 
        //private static long GetFactorial(int number)
        //{          
        //    if (number == 0)
        //    {
        //        return 1;
        //    }
        //    return number * GetFactorial(number-1);
        //}
        }
    }
}
