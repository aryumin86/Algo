using System;

namespace Ch4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { -9, -10, 19, 20, 21, 22, -1, -6, 5, 7, 8, -3, -2 };

            LongestSubArrayDivedeEtImpere lsa = new LongestSubArrayDivedeEtImpere();
            var res = lsa.FindMaximumSubArray(arr, 0, arr.Length - 1);

            Console.WriteLine("Raw array is " + string.Join(",", arr));
            Console.WriteLine("Analysis is done");
            Console.WriteLine(string.Format("Max subarray has {0} start index and {1} end index and {2} sum", 
                                           res[0], res[1], res[2]));

            Console.ReadLine();
        }
    }
}
