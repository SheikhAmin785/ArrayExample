using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayExample
{
    class Example5
    {
        public static void Biya()
        {
            string[] animals = new string[2];
            animals[0] = "alamin";
            animals[1] = "kamal";
            foreach(string item in animals)
            {
                Console.WriteLine($"{item}");
            }

            string[] animal = new string[] { "alamin", "kamal", "jamal" };
            string[] animll = { "alamin", "kamal", "jamal" };

            int[] Daughter = new int[10];
            for(int i = 0; i < 10; i++)
            {
                Daughter[i] = i;
                Console.WriteLine("my value "+Daughter[i]);
            }
            int[,] ar = new int[2, 2];
            int[,,] arr = new int[2, 2, 2];
            int[][] jagg = new int[3][];
            jagg[0] = new int[10];
            jagg[1] = new int[20];
            jagg[2] = new int[30];
           
        }
    }
}
