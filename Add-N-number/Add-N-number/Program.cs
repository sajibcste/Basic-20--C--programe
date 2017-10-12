using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Add_N_number
{
    class Program
    {
        static void Main(string[] args)
        {
            int x,i;
            double y,sum=0;
            Console.WriteLine("Enter The number of integer you want to add");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine( "{0} digit are..",x);

            for ( i=1; i <= x; i++)
            {
                y = Convert.ToDouble(Console.ReadLine());
                sum = sum + y;

            }
            Console.WriteLine("sum of {0} digit are:{1}",x,sum);
            Console.ReadKey();
        }
    }
}
