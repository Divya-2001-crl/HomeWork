using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.Marshalling;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    internal class Electricity
    {
        public static void CurrentBill()
        {
            float units ,total,surcharge;
            
            Console.WriteLine("units used");
            units =Convert.ToSingle(Console.ReadLine());
            if (units <= 100)
            {
                total = units * 1;
                Console.WriteLine("the total is " + total);
            }
            else if ((units > 100) && (units <= 200))
            {
                total = ((100 * 1) + (units - 100) * 2);

                Console.WriteLine("the total bill is " + total);
            }
            else if (units >= 200 && units <= 300)
            {
                total = 100 + (100 * 2) + (units - 200) * 3;
                surcharge = (total + (5 / 100));


                Console.WriteLine("the  bill is " + total);


            }
            else if (units >= 300 && units <= 400)
            {
                total = (((100*1) +(100*2)+(100*3) +(units - 300) * 4) + (8/100));
                
                Console.WriteLine("total bill  " + total);
            }

            else 
            {
                total = (units * 6);
                Console.WriteLine("total bill" +total);
            }

        }
    }
}
