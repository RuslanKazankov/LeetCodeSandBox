using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSandBox.Problems
{
    public static class ReverseVowels345
    {
        public static string ReverseVowelsA(string s)
        {
            List<char> value = new List<char>();
            string VowelsBase = "AEIOUaeiou";
            List<int> IndexesVowels = new List<int>();
            for (int i = 0; i < s.Length; i++)
            {
                value.Add(s[i]);
                if (VowelsBase.Contains(s[i]))
                {
                    IndexesVowels.Add(i);
                }
            }
            for (int i = 0; i < IndexesVowels.Count / 2; i++)
            {
                char a = s[IndexesVowels[i]];
                char b = s[IndexesVowels[IndexesVowels.Count - i - 1]];
                value[IndexesVowels[i]] = b;
                value[IndexesVowels[IndexesVowels.Count - i - 1]] = a;
            }
            string result = string.Join("", value);
            return result;
        }

        public static string ReverseVowelsB(string s)
        {
            string result = "";
            char[] value = new char[s.Length];
            string VowelsBase = "AEIOUaeiou";

            for (int i = 0, j = s.Length - 1; i < j;)
            {
                if (VowelsBase.Contains(s[i]))
                {
                    if (VowelsBase.Contains(s[j]))
                    {
                        value[j] = s[i];
                        value[i] = s[j];
                        i++;
                        j--;
                    }
                    else
                    {
                        j--;
                    }
                }
                else
                {
                    i++;
                }
            }
            for (int i = 0; i < s.Length; i++)
            {
                if (!VowelsBase.Contains(value[i]))
                {
                    result += s[i];
                }
                else
                {
                    result += value[i];
                }
            }
            return result;
        }

    }

}
