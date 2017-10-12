using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swap_Two_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y,temp;
            Console.WriteLine("Enter first number");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter secend number");
            y = int.Parse(Console.ReadLine());
            Console.WriteLine("Before Swapping first number =x {0} and secend number y= {1}", x, y);
            temp = x;
            x = y;
            y = temp;
            Console.WriteLine("After Swapping first number x= {0} and secend number y= {1}", x, y);
            Console.ReadKey();

            //int a = 5, b = 10;
            //Console.WriteLine("Before swap a= " + a + " b= " + b);
            //a = a + b; //a=15 (5+10)      
            //b = a - b; //b=5 (15-10)      
            //a = a - b; //a=10 (15-5)   
            //Console.Write("After swap a= " + a + " b= " + b);   



        }
    }
}
