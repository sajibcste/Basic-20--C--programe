using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddTwoNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y, result;
            Console.WriteLine("\n Enter your first number...");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n Enter your secend number..");
            y = Convert.ToInt32(Console.ReadLine());
            result = x + y;
            Console.WriteLine("sum of " +x+ " and " +y+ " is." +result);
            Console.ReadLine();
        }
    }
}
