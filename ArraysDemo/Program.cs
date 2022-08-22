using System;


namespace ArraysDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = new int[5] {1,2,3,4,5 };

            int[] arr2;
            arr2 = new int[] {10,30,40 };

            int[] arr3 = new int[] { 100, 30, 1 };

            for (int i = 0; i < arr1.Length; i++)
            {
                Console.WriteLine(arr1[i]);
            }

            for (int i = 0; i < arr2.Length; i++)
            {
                Console.WriteLine(arr2[i]);
            }
            Console.WriteLine("------------Using the for each loop----");
            foreach (var element in arr1)
            {
                Console.WriteLine(element);
            
            }

            float[] areas = new float[] { 9.0f, 45.22f, 56.78f,45.45f,5678.33f };
            Console.WriteLine("-------");

            foreach (var item in areas)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("----------------------------");

            int[] a2 = new int[5];

            //a2[0] = 10;
            //a2[1] = 20;
            for (int i = 0; i < a2.Length; i++)
            {
                Console.WriteLine("enter value for a[{0}]" , i );
                a2[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Now Printing....");

            foreach (var item in a2)
            {
                Console.WriteLine(item);

            }
            Console.WriteLine("-------Using create instance----------");

            Array arr=Array.CreateInstance(typeof(int), 10);

            int[] values = (int[])arr;
            Console.WriteLine(values.Length);
            Console.ReadKey();

        }
    }
}


