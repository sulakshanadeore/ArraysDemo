using System;


namespace ArraysDemo
{
    class Program
    {
        static void Main(string[] args)
        {
        //    int[] arr1 = new int[5] {1,2,3,4,5 };

        //    int[] arr2;
        //    arr2 = new int[] {10,30,40 };

        //    int[] arr3 = new int[] { 100, 30, 1 };

        //    for (int i = 0; i < arr1.Length; i++)
        //    {
        //        Console.WriteLine(arr1[i]);
        //    }

        //    for (int i = 0; i < arr2.Length; i++)
        //    {
        //        Console.WriteLine(arr2[i]);
        //    }
        //    Console.WriteLine("------------Using the for each loop----");
        //    foreach (var element in arr1)
        //    {
        //        Console.WriteLine(element);
            
        //    }

        //    float[] areas = new float[] { 9.0f, 45.22f, 56.78f,45.45f,5678.33f };
        //    Console.WriteLine("-------");

        //    foreach (var item in areas)
        //    {
        //        Console.WriteLine(item);
        //    }
        //    Console.WriteLine("----------------------------");

        //    int[] a2 = new int[5];

        //    //a2[0] = 10;
        //    //a2[1] = 20;
            
        //    //property/characteristic of the array
            
        //    //spanner---property
        //    //Cuboid---method
        //    //Lightning---event
        //    //{}--namespace


        //    for (int i = 0; i < a2.Length; i++)
        //    {
        //        Console.WriteLine("enter value for a[{0}]" , i );
        //        //Index of the array
        //        a2[i] = Convert.ToInt32(Console.ReadLine());
        //    }
        //    Console.WriteLine("Now Printing....");
            
        //    foreach (var item in a2)
        //    {
        //        Console.WriteLine(item);

        //    }
        //    Console.WriteLine("-------Using create instance----------");

        //    Array arr=Array.CreateInstance(typeof(int), 10);

        //    int[] values = (int[])arr;
        //    Console.WriteLine(values.Length);
        //    Console.WriteLine("---------------------------------");

            int[] prices = new int[]{10,20,30,22,45,567,89};
            

            foreach (var item in prices)
            {
                Console.WriteLine(item);
            }

            prices[5] = 1000;
            Array.Sort(prices);
            Array.Reverse(prices);
            Console.WriteLine("After new array element: ");
            foreach (var item in prices)
            {
                Console.WriteLine(item);
            }

            int[] prices_copy = new int[prices.Length];
            Array.Copy(prices, prices_copy, prices.Length);
            Console.WriteLine("Copied array");
            foreach (var item in prices_copy)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("-------clear array------------");
            Array.Clear(prices, 0, prices.Length);
            foreach (var item in prices)
            {
                Console.WriteLine(item);
            }
           
           








            Console.ReadKey();

        }
    }
}


