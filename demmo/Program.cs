using System;

namespace demmo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            //Console.WriteLine("hii");

            int[] arr = new int[6] { 105, 101, 100, 102, 99, 58 };
            Console.WriteLine("_____printing array______________");
            for(int i=0;i<arr.Length;i++)
            {
                Console.WriteLine(arr[i]);
            }
            Console.WriteLine("_______printing string array________________");
            string[] days = new string[7] { "monday", "tuseday", "wensday", "thrustday", "friday", "saturday", "sunday" };
            for(int i=0;i<days.Length;i++)
            {
              Console.WriteLine(days[i]);
            }
            Console.WriteLine("________sorting string array______________");
            Array.Sort(days);
            for(int i=0;i<days.Length;i++)
            {
                Console.WriteLine(days[i]);
            }
            Console.WriteLine("________sorting int array______________");
            Array.Sort(arr);
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
            Console.WriteLine("____________reverse int array______________");
            Array.Reverse(arr);
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
            //Array.Copy(days, 1, arr, 0, 2);
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.WriteLine(arr[i]);
            //}
            Console.WriteLine("_______________clear array_________");
            Array.Clear(arr, 2, 4);
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }




        }
    }
}
