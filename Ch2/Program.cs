using System;

namespace Ch2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 5, 4, 55, 54, 53, 52, 3, 4, 2, 3, 6, 7, 8, 4, 6 };
            arr = InsertSort.Sort(arr);
            foreach (int i in arr)
                Console.WriteLine(i);


            Console.ReadLine();
        }
    }
}
