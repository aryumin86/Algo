using System;
namespace Ch4
{
    /// <summary>
    /// Longest sub array divede et impere.
    /// </summary>
    public class LongestSubArrayDivedeEtImpere
    {
        public int[] FindMaxCrossingSubArray(int[] arr, int low, int mid, int high){
            int[] res = new int[3];
            int sum = 0;
            int leftSum = int.MinValue;
            int rightSum = int.MinValue;
            int maxLeft = mid;
            int maxRight = mid;

            for (int i = mid; i >= low; i--){
                sum = sum + arr[i];
                if (sum > leftSum){
                    leftSum = sum;
                    maxLeft = i;
                }
            }

            sum = 0;
            for (int i = mid + 1; i <= high; i++){
                sum = sum + arr[i];
                if(sum > rightSum){
                    rightSum = sum;
                    maxRight = i;
                }
            }

            res[0] = maxLeft;
            res[1] = maxRight;
            res[2] = leftSum + rightSum;

            return res;
        }


        public int[] FindMaximumSubArray(int[] arr, int low, int high){

            int leftLow = 0;
            int leftHigh = 0;
            int rightLow = 0;
            int rightHigh = 0;
            int crossLow = 0;
            int crossHigh = 0;
            int leftSum = 0;
            int rightSum = 0;
            int crossSum = 0;

            if (low + 1 == high)
                return new int[] { low + 1, high, arr[low] };
            else{
                int mid = (low + high) / 2;
                int[] left = FindMaximumSubArray(arr, low, mid);
                leftLow = left[0];
                leftHigh = left[1];
                leftSum = left[2];

                int[] right = FindMaximumSubArray(arr, mid, high);
                rightLow = right[0];
                rightHigh = right[1];
                rightSum = right[2];

                int[] cross = FindMaxCrossingSubArray(arr, low, mid, high);
                crossLow = cross[0];
                crossHigh = cross[1];
                crossSum = cross[2];

                if (leftSum >= rightSum && leftSum >= crossSum)
                    return new int[] { leftLow, leftHigh, leftSum };
                else if (rightSum >= leftSum && rightSum >= crossSum)
                    return new int[] { rightLow, rightHigh, rightSum };
                else
                    return new int[] { crossLow, crossHigh, crossSum };
            }
        }
    }
}
