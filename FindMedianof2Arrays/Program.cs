using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMedianof2Arrays
{
    public class Solution
    {
        
            static double FindMedianSortedArrays(int[] nums1, int[] nums2)
            {
            double m;
            int[] nums3 = new int [nums1.Length + nums2.Length];
            int Tlen;
            Array.Copy(nums1, nums3, nums1.Length);
            Array.Copy(nums2,0, nums3, nums1.Length, nums2.Length);
            Array.Sort(nums3);
            Tlen = nums3.Length;
            // Now we need to figerout if array is even then there will be two medians
            if (Tlen % 2 == 0)
            {
                double [] temp = new double[2];
                temp[0] = nums3[(Tlen / 2)-1];
                temp[1] = nums3[(Tlen/2)];
                m = (temp[0] + temp[1]) / 2;
            }
            else 
            {
                m = nums3[Tlen / 2];  
            }

            return m;
            }
        
        static void Main(string[] args)
        {
            int[] num1 = new int[2] { 1, 3 };
            int[] num2 = new int[1] { 2 };
            double Median;
            Median = FindMedianSortedArrays(num1, num2);
            Console.Write("The median is: ");
            Console.Write(Median);
            Console.ReadLine();
        }
    }
}
