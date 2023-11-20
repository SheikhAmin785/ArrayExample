using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayExample
{
    class example2
    {
        static void Main()
        {
            int[,] arr = new int[3,3];

            arr[0, 1] = 10;
            arr[1, 2] = 20;
            arr[2, 0] = 30;

            for(int i = 0; i <=3; i++)
            {
                for(int j = 0; j <= 3; j++)
                {
                    Console.WriteLine($"{[i+""+j]}");
                    Console.WriteLine(""+[i,j]);
                }
            }
            {

            }
        }
    }
}
