using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_Maximum_Subarray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { -2, 1, -3, 4, -1, 2, 1, -5, 4 };
            int current = nums[0];
            int max = nums[0];

            for(int i = 1; i < nums.Length; i++)
            {
                if (current + nums[i] > nums[i])
                {
                    current += nums[i];
                }
                else
                {
                    current = nums[i];
                }
                if(current > max)
                {
                    max = current;
                }
            }
            Console.WriteLine(max);
            Console.ReadLine();
        }
    }
}
