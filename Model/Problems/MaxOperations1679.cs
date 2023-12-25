using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSandBox.Problems
{
    public class MaxOperations1679 : Problem
    {
        public override int Number => 1679;

        public override string Title => "Max Number of K-Sum Pairs";

        protected override string EngDescription
        {
            get
            {
                return "You are given an integer array nums and an integer k.\n" +
                    "In one operation, you can pick two numbers from the array whose sum equals k and remove them from the array.\n" +
                    "Return the maximum number of operations you can perform on the array.";
            }
        }

        protected override string RusDescription
        {
            get
            {
                return "Вам задан целочисленный массив nums и целое число k.\n" +
                    "За одну операцию вы можете выбрать из массива два числа, сумма которых равна k, и удалить их из массива.\n" +
                    "Возвращает максимальное количество операций, которые вы можете выполнить с массивом.";
            }
        }

        public int Solve(int[] nums, int k)
        {
            Array.Sort(nums);
            int operations = 0;
            int right = nums.Length - 1;
            if (k <= nums.Min())
            {
                return operations;
            }
            while (nums[right] >= k)
            {
                right--;
            }
            for (int i = 0, j = right; i < j;)
            {
                if (nums[i] + nums[j] == k)
                {
                    operations++;
                    i++;
                    j--;
                }
                else if (nums[i] + nums[j] < k)
                {
                    i++;
                }
                else
                {
                    j--;
                }
            }
            return operations;
        }

        public override string Test()
        {
            int[] arr = ConsoleReader.TryReadIntArray();
            if (arr == null) return null;

            if (!ConsoleReader.ReadInt(out int k)) return null;

            return Solve(arr, k).ToString();
        }
    }
}
