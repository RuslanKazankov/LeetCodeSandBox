using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSandBox.Problems
{
    public static class BuilderProblem
    {
        private static readonly Dictionary<int, Problem> problems = new Dictionary<int, Problem>()
        {
            { 643, new FindMaxAverage643() },
            { 151, new ReverseWords151() },
            { 11, new MaxArea11() },
            { 1679, new MaxOperations1679() }
        };

        /// <summary>
        /// Возвращает задачу по её номеру. Если номера нет, возвращает null
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public static Problem GetProblem(int num)
        {
            if (problems.ContainsKey(num))
            {
                return problems[num];
            }
            return null;
        }

        public static String[] GetTitleList()
        {
            String[] titleList = new string[problems.Count()];
            int i = 0;
            foreach (var problem in problems)
            {
                titleList[i] += problem.Value.FullTitle;
                i++;
            }
            return titleList;
        }
    }
}
