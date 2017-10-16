using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PrimeNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int x,Count;
            Console.WriteLine("Please enter your number to check prime");
            x = int.Parse(Console.ReadLine());
            for (Count = 2; Count <= x - 1; Count++)
            {
                if (x%Count == 0)
                {
                    Console.WriteLine("Number is not prime");
                    break;
                }
                
            }
            if (x == Count)
            {
                Console.WriteLine("Number is prime");
            }
            Console.ReadKey();

        }
    }
}
 //if ( n >= 1 )
 //  {
 //     printf("First %d prime numbers are :\n",n);
 //     printf("2\n");
 //  }
 
 //  for ( count = 2 ; count <= n ;  )
 //  {
 //     for ( c = 2 ; c <= i - 1 ; c++ )
 //     {
 //        if ( i%c == 0 )
 //           break;
 //     }
 //     if ( c == i )
 //     {
 //        printf("%d\n",i);
 //        count++;
 //     }
   //   i++;
   //}
