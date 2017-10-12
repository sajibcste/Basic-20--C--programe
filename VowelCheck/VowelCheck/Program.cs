using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VowelCheck
{
    class Program
    {
        static void Main(string[] args)
        {
            char x;
            Console.WriteLine("Enter a character..");
            x = Convert.ToChar(Console.ReadLine().ToLower());
            if (x == 'a' || x == 'e' || x == 'i' || x == 'o' || x == 'u')
            {
                Console.WriteLine("\n charater" + x + "is vowel");
            }
            else
            {
                Console.WriteLine("character" + x + "is constant");
            }
            Console.ReadLine();
        }
    }
}
