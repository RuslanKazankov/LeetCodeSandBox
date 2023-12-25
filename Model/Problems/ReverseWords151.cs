using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSandBox.Problems
{
    public class ReverseWords151 : Problem
    {
        public override int Number => 151;

        public override string Title => "Reverse Words in a String";

        protected override string EngDescription
        {
            get
            {
                return "Given an input string s, reverse the order of the words.\n" +
                    "A word is defined as a sequence of non-space characters. The words in s will be separated by at least one space.\n" +
                    "Return a string of the words in reverse order concatenated by a single space.\n" +
                    "Note that s may contain leading or trailing spaces or multiple spaces between two words.\n" +
                    "The returned string should only have a single space separating the words. Do not include any extra spaces.";
            }
        }

        protected override string RusDescription
        {
            get
            {
                return "Учитывая входную строку s, измените порядок слов в обратном порядке.\n" +
                    "Слово определяется как последовательность символов без пробелов. Слова в s будут разделены по крайней мере одним пробелом.\n" +
                    "Возвращает строку слов в обратном порядке, объединенную одним пробелом.\r\n\r\n" +
                    "Обратите внимание, что s может содержать начальные или конечные пробелы или несколько пробелов между двумя словами.\n" +
                    "Возвращаемая строка должна содержать только один пробел, разделяющий слова. Не включайте никаких дополнительных пробелов.";
            }
        }

        public string Solve(string s)
        {
            string[] words = s.Split(' ');
            string result = "";
            foreach (string word in words.Reverse())
            {
                if (word != "")
                {
                    result += word + " ";
                }
            }
            return result.Trim();
        }

        public override string Test()
        {
            return Solve(ConsoleReader.ReadString());
        }
    }
}
