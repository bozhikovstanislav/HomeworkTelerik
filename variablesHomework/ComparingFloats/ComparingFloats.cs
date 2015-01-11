using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComparingFloats
{
    class ComparingFloats
    {
        static void Main(string[] args)
        {
            double precision = 0.000001;
            char[] presitionA = precision.ToString().ToCharArray();
            Console.WriteLine("Enter a number a");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter number b = ");
            double b = double.Parse(Console.ReadLine());
            double substratction = a - b;

           
            for (int i = 0; i < presitionA.Length; i++)
            {
                
            }

            Console.ReadLine();
        }
    }
}
