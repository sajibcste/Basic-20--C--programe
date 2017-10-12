using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadVowelConstant
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] x = new char[100];
            int y,i, vowel = 0, constant = 0, space = 0;
            Console.WriteLine("Enter the length of sentance.. ");
            y = int.Parse(Console.ReadLine());

            for ( i =0;i<y;i++)
            {
                x[i] = Convert.ToChar(Console.Read());
            }

            for (i = 0; x[i]!= '\0'; i++)
            {
                if (x[i] == 'a' || x[i] == 'e' || x[i] == 'i' || x[i] == 'o' || x[i] == 'u')
                {
                    vowel++;
                }
                else if(char.IsWhiteSpace(x[i]))
                {
                    space++;
                }
                else
                {
                    constant++;
                }


            }
            Console.WriteLine("Total vowel of this sentence"+vowel);
            Console.WriteLine("Total constant of this sentence"+constant);
            Console.Write("Total space of this sentence"+space);
            Console.ReadLine();
            Console.ReadLine();

        }
    }
}
