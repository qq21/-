using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] num1 = new int[]{ 1, 2, 3, 0, 0, 0 };
            int[] num2 = new int[] { 2, 5, 6 };

            Console.WriteLine(1 / 2);
            Merge(num1, 3, num2, 3);

           
            int n = num1.Length;
            for (int i = 0; i < n / 2; i++)
            {
                Console.WriteLine(num1[i]);
                Console.WriteLine(num1[ n - i-1]);
            }
        }

       

        public static void Merge(int[] nums1, int m, int[] nums2, int n)
        {

            //int tempI = 0;

            // for (int i = 0; i < m; i++)
            // {
            //     if (nums2[tempI]>nums1[i]) //
            //     {
            //         for (int j = m-1+tempI; j >=i+1; j--) //把i外后的数 外后移动
            //         {
            //             nums1[j + 1] = nums1[j];
            //         }

            //         nums1[i+1] = nums2[tempI];

            //         tempI++;
            //     }

            // }

            for (int i = nums1.Length-1; i>=m; i--)
            {
                nums1[i] = nums2[i - m];
            }
            Array.Sort(nums1);

        }
    }
}
