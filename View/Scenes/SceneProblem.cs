using LeetCodeSandBox.Problems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSandBox.View
{
    public class SceneProblem : Scene
    {
        public Problem CurrentProblem { get; set; }
        protected override void Main()
        {
            Console.WriteLine(CurrentProblem.FullTitle);
            Console.WriteLine(CurrentProblem.Description());
            Console.WriteLine("\nВведите \"/test\", чтобы протестировать задачу. \"/translate\" - перевести задачу eng/rus.");
        }

        protected override bool ReadCommand(string command)
        {
            if (command == "/test")
            {
                string result = CurrentProblem.Test();
                Console.WriteLine(result ?? "Данные введены не верно" + ". Тест завершён.");
            }
            else if (command == "/translate")
            {
                CurrentProblem.Translate();
                return true;
            }
            else
            {
                ConsoleWriter.UnknownCommand();
            }
            return false;
        }
    }
}
