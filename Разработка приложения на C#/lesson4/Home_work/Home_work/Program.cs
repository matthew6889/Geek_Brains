using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_work
{ 
    internal class Program
    {
        static List<int> FindThreeNumbers(int[] nums, int target)
        {
            Array.Sort(nums);

            List<int> result = new List<int>();

            for (int i = 0; i < nums.Length - 2; i++)
            {
                int left = i + 1;
                int right = nums.Length - 1;

                while (left < right)
                {
                    int sum = nums[i] + nums[left] + nums[right];

                    if (sum == target)
                    {
                        result.Add(nums[i]);
                        result.Add(nums[left]);
                        result.Add(nums[right]);
                        break;
                    }
                    else if (sum < target)
                    {
                        left++;
                    }
                    else
                    {
                        right--;
                    }
                }

                if (result.Count > 0)
                {
                    break;
                }


            }
            return result;
        }

        static void Main(string[] args)
        {

            int[] nums = { -1, 0, 1, 2, -1, -4 };

            int target = 0;

             List<int> result = FindThreeNumbers(nums, target);

            if (result.Count > 0)
            {
                Console.WriteLine("Найдена комбинация трех чисел: " + result[0] + ", " + result[1] + ", " + result[2]);
            }
            else
            {
                Console.WriteLine("Комбинация не найдена");
            }
        }
    }
    
}
