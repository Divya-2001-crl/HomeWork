using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    internal class Compare
    {
        public static void Main()
        {
            Installment.monthlyinstall();
            //Sum.number();
           // NaturalNum.series();
            //Electricity.CurrentBill();
            //LargestOfFour();
            //LargestOfThree();
            //LargestOfTwo();
        
        }
        
        public static void LargestOfTwo()
        {
            int a, b;
            Console.WriteLine("enter the value  of a");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the value of b");
            b = Convert.ToInt32(Console.ReadLine());
            if (a > b)
            {
                Console.WriteLine("a is greater");
            }
            else
            {
                Console.WriteLine("b is greater");
            }
        }
        public static void LargestOfThree()
        {
            int a, b, c;
            Console.WriteLine("enter the value of a");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the value of b");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the value of c");
            c = Convert.ToInt32(Console.ReadLine());
            if ((a > b) && (a > c))
            {



                Console.WriteLine("a is greater");
            }
            else if (b > c)
            {
                Console.WriteLine("b is greater");
            }
            else
            {
                Console.WriteLine("c is greater");


            }
        }
        public static void LargestOfFour()
        {
            int a, b, c, d;
            Console.WriteLine("enter the value of a");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the value of b");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the value of c");
            c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the vallue of d");
            d = Convert.ToInt32(Console.ReadLine());
            if ((a > b) && (a > c) && (a > d))
            {



                Console.WriteLine("a is greater");
            }
            else if ((b > c) && (b > d))
            {
                Console.WriteLine("b is greater");
            }
            else if (c > d)
            {
                Console.WriteLine("c is greater");


            }
            else
            {
                Console.WriteLine("d is greater");
            }
        }


    }
}
