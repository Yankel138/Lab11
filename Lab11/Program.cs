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
            public float k;
            public float b;

            public Equation(float k, float b)
            {
                this.k = k;
                this.b = b;
            }
            public void Root()
            {
                float x = -b / k;
                Console.WriteLine($"0 = {k}x + {b}\nx = {x}");
            }
        }

        static void Main(string[] args)
        {
            Equation eq1 = new Equation(2, 3);
            eq1.Root();
            Equation eq2 = new Equation(10, 3);
            eq2.Root();
            Console.ReadKey();
        }
    }
}
