
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSandBox.Problems
{
    public class FindMaxAverage643 : Problem
    {
        public override int Number => 643;

        public override string Title => "Maximum Number of Vowels in a Substring of Given Length";
        protected override string EngDescription
        {
            get
            {
                return "You are given an integer array nums consisting of n elements, and an integer k.\n" +
                    "Find a contiguous subarray whose length is equal to k that has the maximum average value and return this value. \n" +
                    "Any answer with a calculation error less than 10-5 will be accepted.";
            }
        }

        protected override string RusDescription
        {
            get
            {
                return "Вам предоставляется целочисленный массив, nums состоящий из n элементов, и целое число k.\n" +
                    "Найдите непрерывный подмассив, длина которого равна k, который имеет максимальное среднее значение, и верните это значение. \n" +
                    "Будет принят любой ответ с ошибкой вычисления меньше 10-5.";
            }
        }

        public double Solve(int[] nums, int k)
        {
            double curentAverage = 0;
            for (int i = 0; i < k; i++)
            {
                curentAverage += nums[i];
            }
            curentAverage /= k;

            double maxAverage = curentAverage;
            for (int i = k; i < nums.Length; i++)
            {
                curentAverage -= (double)nums[i - k] / k;
                curentAverage += (double)nums[i] / k;
                if (curentAverage > maxAverage)
                {
                    maxAverage = curentAverage;
                }
            }
            return maxAverage;
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
