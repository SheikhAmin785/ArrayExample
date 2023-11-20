using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayExample
{
    class Example4
    {
        public static int Addd(params int[] Numbers)
        {
            int total = 0;
            foreach(int i in Numbers)
            {
                total += i;
            }

        }
        static void Main()
        {
            int y =Addd{ 10, 20, 30, 40, 50 };
            Console.WriteLine(y);
            Array.Copy();


        }
    }
}
