using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSandBox.Problems
{
    public static class KidsWithCandies1431
    {
        public static IList<bool> KidsWithCandies(int[] candies, int extraCandies)
        {
            bool[] bigKids = new bool[candies.Length];
            int maxCandy = candies.Max();
            for (int i = 0; i < candies.Length; i++)
            {
                bigKids[i] = (candies[i] + extraCandies >= maxCandy);
            }
            return bigKids;
        }
    }
}
