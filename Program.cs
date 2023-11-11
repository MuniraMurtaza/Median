
namespace median {
    using System;
    using System.ComponentModel.Design;
   
    
    public class Solution
    {
        
        static void Main(string[] args)
        {
            int[] nums1 = new int[] { 1, 2, 3 };
            int[] nums2 = { 6, 7 , 8 };

            Console.WriteLine(FindMedianSortedArrays(nums1,nums2));

        }
         static double FindMedianSortedArrays(int[] nums1, int[] nums2) {
           double median = 0.0;
           nums1 = nums1.Concat(nums2).ToArray();
           int arrayLength = nums1.Length;
           
           median = arrayLength == 0? 0 : (arrayLength % 2 == 1) ?Convert.ToDouble((arrayLength + 1) / 2): Convert.ToDouble((( arrayLength / 2) + ((arrayLength / 2) + 1)) / 2);
           
            
            
            return median;
        }

    }



}
