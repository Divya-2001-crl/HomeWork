using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    internal class Sum
    {
        public static void number()
        {
            int i, s = 0,n;
            
            Console.WriteLine("enter the n number");
            n = Convert.ToInt32(Console.ReadLine());

            for (i = 0; i<=n; i++)
            {
                s = (s + i);
                
            }
            Console.WriteLine(s);
        }
        
    }
}
