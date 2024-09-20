using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    internal class NaturalNum
    {
        public static void series()
        {
            int a = 0,b = 1, c, n, i;
            Console.WriteLine("enter the number");
            n=Convert.ToInt32(Console.ReadLine());
            

            for(i=0;i<=n;i++)
                {
                
                c = a + b;
                Console.WriteLine(" " + c);
                a = b;
                b = c;

            }
        }
    }
}
