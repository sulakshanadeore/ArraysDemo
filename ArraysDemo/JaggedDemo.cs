using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysDemo
{
    class JaggedDemo
    {
        static void Main(string[] args)
        {
            int[][] jagged_arr = new int[][] 
            { 
                new int[] { 1,2,3,4} ,
                new int[] {11,12,15},
                new int[] { 89,90 },
                new int[] { 2,100,55,78,90}
            
            };

            int[][] jagged_second={
                new int[] { 1,2,3,4} ,
                new int[] {11,12,15},
                new int[] { 89,90 },
                new int[] { 2,100,55,78,90}

            };

            int[][] jagged_third = new int[4][];
            
            jagged_third[0] = new int[4] {10,20,30,40 };
            jagged_third[1] = new int[] { 100, 200, 300, 400, 500 };
            jagged_third[2] = new int[] { 2, 3 };
            jagged_third[3] = new int[] { 1000, 2000, 3000, 4000 };

            //for (int n = 0; n < jagged_third.Length; n++)
            //{
            //    Console.WriteLine("Row ({0})  ", n);
            //    for (int i = 0; i < jagged_third[n].Length; i++)
            //    {
            //        Console.Write(jagged_third[n][i] +"\t " );
            //    }
            //    Console.WriteLine();

            //}


            foreach (var item in jagged_third)
            {
                Console.WriteLine("Row ({0})  ", item);
                foreach (var i in item)
                {
                    Console.WriteLine(i +" \t");
                }
                Console.WriteLine();
            }

            Console.Read();
           

        }
    }
}
