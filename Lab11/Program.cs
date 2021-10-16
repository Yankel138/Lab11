using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11
{
    class Program
    {
        struct Equation
        {
            public double k;
            public double b;

            public Equation(double k, double b)
            {
                this.k = k;
                this.b = b;
            }
            public void Root()
            {
                double x = -b / k;
                Console.WriteLine($"0 = {k}x + {b}\nx = {x:f2}");
            }
        }

        static void Main(string[] args)
        {
            Equation eq1 = new Equation(-2, 3);
            eq1.Root();
            
            Equation eq2;
            eq2.k = 12.5;
            eq2.b = 2.5;
            eq2.Root();
            
            Console.ReadKey();
        }
    }
}
