using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayExample
{
    class Example1
    {
        static void Printarr(int ar)
        {
            int[] p = new int[5];
            for(int i = 0; i <= p.Length; i++)
            {
                Console.WriteLine($"{p[i]}");
            }
        }
        static void Main()
        {
            int[] arrw = { 10, 20, 30, 40, 50 };
            int[] arrt = { 10, 30, 50, 70, 80 };

            Printarr(arrw);

        }
    }
}
