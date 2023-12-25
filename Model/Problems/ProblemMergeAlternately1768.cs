using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSandBox.Problems
{
    public static class ProblemMergeAlternately1768
    {
        public static string MergeAlternately(string word1, string word2)
        {
            if (word1.Length >= word2.Length)
            {
                for (int i = 0; i < word2.Length; i++)
                {
                    word1 = word1.Insert(i * 2 + 1, word2[i].ToString());
                }
                return word1;
            }
            for (int i = 0; i < word1.Length; i++)
            {
                word2 = word2.Insert(i * 2, word1[i].ToString());
            }
            return word2;
        }
    }
}
