using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSandBox.Problems
{
    public static class GcdOfStrings1071
    {
        public static string GcdOfStrings(string str1, string str2)
        {
            string value = "";
            int nod = NOD(str1.Length, str2.Length);
            List<int> divides = new List<int>();
            for (int i = 1; i <= Math.Sqrt(nod); i++)
            {
                if (DivideString(str1.Substring(0, nod / i), str2) && DivideString(str1.Substring(0, nod / i), str1))
                {
                    return str1.Substring(0, nod / i);
                }
                else if (DivideString(str1.Substring(0, i), str2) && DivideString(str1.Substring(0, i), str1))
                {
                    divides.Add(i);
                }
            }
            if (divides.Count != 0)
            {
                return str1.Substring(0, divides.Max());
            }

            return value;
        }

        private static bool DivideString(string str1, string str2)
        {
            int len1 = str1.Length;
            int len2 = str2.Length;
            string newStr = "";
            if (len1 >= len2)
            {
                for (int i = 0; i < len1 / len2; i++)
                {
                    newStr += str2;
                }
                if (newStr == str1)
                {
                    return true;
                }
                return false;
            }
            else
            {
                for (int i = 0; i < len2 / len1; i++)
                {
                    newStr += str1;
                }
                if (newStr == str2)
                {
                    return true;
                }
                return false;
            }
        }

        public static int NOD(int a, int b)
        {
            while (a != 0 && b != 0)
            {
                if (a > b)
                {
                    a %= b;
                }
                else
                {
                    b %= a;
                }
            }
            return Math.Max(a, b);
        }
    }
}
