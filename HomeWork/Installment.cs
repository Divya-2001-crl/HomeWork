using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    internal class Installment
    {
        public static void monthlyinstall()
        {
            float p, t, r, SI, CI,n;
            
            Console.WriteLine("enter the principle amount");
            p =Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("enter the time");
            t = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("enter the rate of interest");
            r= Convert.ToSingle(Console.ReadLine());
            //Console.WriteLine("enter thevalue of n ");
            //n= Convert.ToSingle(Console.ReadLine());
            SI = (p * t * r) / 100;
            Console.WriteLine("simple interest is"+SI);
            CI = t * SI / 100;
            Console.WriteLine("Compound interest" +CI); 



            
                
          
            
        
    
           
        }
    }
}
