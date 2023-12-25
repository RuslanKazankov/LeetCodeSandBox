using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSandBox.Problems
{
    public class MaxArea11 : Problem
    {
        public override int Number => 11;

        public override string Title => "Container With Most Water";

        protected override string EngDescription
        {
            get
            {
                return "You are given an integer array height of length n.\n There are n vertical lines drawn such that the two endpoints of the ith line are (i, 0) and (i, height[i]).\n" +
                    "Find two lines that together with the x-axis form a container, such that the container contains the most water.\n" +
                    "Return the maximum amount of water a container can store.\n" +
                    "Notice that you may not slant the container.";
            }
        }

        protected override string RusDescription
        {
            get
            {
                return "Вам будет предоставлен целочисленный массив height длины n.\n" +
                    "На нем нарисованы n вертикальные линии таким образом, что двумя конечными точками ith линии являются (i, 0) и (i, height[i]).\n" +
                    "Найдите две линии, которые вместе с осью x образуют контейнер таким образом, чтобы контейнер содержал наибольшее количество воды.\n" +
                    "Верните максимальное количество воды, которое может вместить контейнер.\n" +
                    "Обратите внимание, что вы не должны наклонять емкость.";
            }
        }

        public override string Test()
        {
            int[] arr = ConsoleReader.TryReadIntArray();
            if (arr == null) return null;

            return Solve(arr).ToString();
        }

        public int Solve(int[] height)
        {
            int maxArea = int.MinValue;
            for (int i = 0, j = height.Length - 1; i < j;)
            {
                int curentArea = Math.Min(height[i], height[j]) * (j - i);
                if (curentArea > maxArea)
                {
                    maxArea = curentArea;
                }
                if (height[i] > height[j])
                {
                    int curentMaxRight = height[j];
                    while (curentMaxRight >= height[j] && j > i)
                    {
                        j--;
                    }
                }
                else
                {
                    int curentMaxLeft = height[i];
                    while (height[i] <= curentMaxLeft && j > i)
                    {
                        i++;
                    }
                }
            }
            return maxArea;
        }
        public int MaxAreaFirst(int[] height)
        {
            int imax = Array.IndexOf(height, height.Max());
            int maxArea = int.MinValue;
            while (imax >= 0)
            {
                for (int i = height.Length - 1; i > imax; i--)
                {
                    int curentArea = (i - imax) * Math.Min(height[i], height[imax]);
                    if (curentArea > maxArea)
                    {
                        maxArea = curentArea;
                    }
                    if (height[imax] <= height[i])
                    {
                        break;
                    }
                }
                if (imax == 0)
                {
                    break;
                }
                imax = Array.IndexOf(height, GetMaxContext(height, imax));
            }
            return maxArea;
        }


        private int GetMaxContext(int[] arr, int right)
        {
            int max = int.MinValue;
            for (int i = 0; i < right; i++)
            {
                if (max < arr[i])
                {
                    max = arr[i];
                }
            }
            return max;
        }
    }
}
