using System;
using static System.Net.Mime.MediaTypeNames;


namespace LeetCodeSandBox
{
    public static class ConsoleWriter
    {
        public static void WriteList(string[] text) { 
            foreach (string line in text)
            {
                Console.WriteLine(line);
            }
        }

        public static void ErrorText(string text)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(text);
            Console.ForegroundColor = ConsoleColor.White;
        }

        public static void UnknownCommand()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Неизвестная команда");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
