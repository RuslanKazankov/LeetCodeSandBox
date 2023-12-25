using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSandBox.Problems
{
    public static class ConsoleReader
    {
        public static int[] TryReadIntArray()
        {
            Console.WriteLine("Введите массив чисел через пробел:");
            string input = Console.ReadLine();
            string[] inputs = input.Split(' ');
            int[] arr = new int[inputs.Length];
            for (int i = 0; i < inputs.Length; i++)
            {
                if (!int.TryParse(inputs[i], out arr[i]))
                {
                    return null;
                }
            }
            return arr;
        }
        public static bool ReadInt(out int k)
        {
            Console.WriteLine("Введите число:");
            if (int.TryParse(Console.ReadLine(), out k))
                return true;
            return false;
        }

        public static string ReadString()
        {
            Console.WriteLine("Введите строку:");
            return Console.ReadLine();
        }
    }
}
