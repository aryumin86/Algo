using System;
using System.Collections.Generic;
using System.Linq;

namespace Ch4
{
    public class LongestSubArrayRude
    {
        public int[] FindMaxSubArray(int[] arr){
            int[] res = new int[3];
            int maxSum = 0;
            int leftIndex = 0;
            int rightIndex = 0;

            for (int i = 0; i < arr.Length; i++){
                int toTake = 1;
                for (int j = i + 1; j < arr.Length; j++, toTake++){
                    
                    int sum = arr.Skip(i).Take(toTake).Sum();

                    if (sum > maxSum){
                        maxSum = sum;
                        leftIndex = i;
                        rightIndex = j - 1;
                    }   
                }
            }

            res[0] = leftIndex;
            res[1] = rightIndex;
            res[2] = maxSum;
            return res;
        }
    }
}
