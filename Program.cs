using System;

namespace ArrayExample
{
    class Program
    {
        static void arr()
        {
            int[] arrr = new int[10];
            int[] ark = new int[] { 10, 20, 30, 40, 50 };
            int[] art = { 10, 20, 30, 40, 50 };
            int[,] are = new int[2, 3];
            int[,,] arx = new int[3, 3, 3];
            int[][] jagg = new int[3][];
            jagg[0] = new int[10];
            jagg[1] = new int[20];
            jagg[2] = new int[30];

            for(int i = 0; i <= ark.Length; i++)
            {
                Console.WriteLine($"{ark[i]}");
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
