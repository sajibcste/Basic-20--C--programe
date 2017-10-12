using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCF_AND_GCD
{
    class Program
    {
        static void Main(string[] args)
        {

            int a, b, x, y, t, gcd, lcm;
            Console.WriteLine("Enter two integers\n");
            x = Convert.ToInt32(Console.ReadLine());
            y = Convert.ToInt32(Console.ReadLine());

            a = x;
            b = y;

            while (b != 0)
            {
                t = b;
                b = a % b;
                a = t;
            }

            gcd = a;
            lcm = (x * y) / gcd;
            Console.WriteLine("Greatest common divisor of {0} and {1}= {2}\n", x, y, gcd);
            Console.WriteLine("Least common multiple of{0} and {1}= {2}\n", x, y, lcm);
            Console.ReadKey();
        }
    }
}
