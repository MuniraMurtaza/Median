// See https://aka.ms/new-console-template for more information
namespace median {
    using System;
    using System.ComponentModel.Design;
   
    
    public class Solution
    {
        
        static void Main(string[] args)
        {
            int[] nums1 = new int[] { 1, 2, 3, 4, 5, };
            int[] nums2 = { 6, 7, 8, 9, 10 };

            Console.WriteLine(FindMedianSortedArrays(nums1,nums2));

        }
         static double FindMedianSortedArrays(int[] nums1, int[] nums2) {
            double median = 0;
            int[] num = new int[nums1.Length+nums2.Length];
                
            Array.Copy(nums1,num,nums1.Length);
            Array.Copy(nums2,0, num, nums1.Length,nums2.Length);
            if (nums1.Length != 0)
            {
                if (nums1.Length % 2 == 1)
                {
                    median = (num.Length + 1) / 2;

                }
                else
                {
                    median = ((num.Length / 2) + ((num.Length / 2) + 1)) / 2;

                }
            }
            return median;
        }

    }



}
