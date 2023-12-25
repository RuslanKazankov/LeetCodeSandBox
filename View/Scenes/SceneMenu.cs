using LeetCodeSandBox.Problems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSandBox.View
{
    public class SceneMenu : Scene
    {
        protected override void Main()
        {
            //Вывод
            Console.WriteLine("Привет! Здесь содержатся некоторые задачи, решённые мной, с сайта leetcode.com.");
            Console.WriteLine("Список задач: ");
            ConsoleWriter.WriteList(BuilderProblem.GetTitleList());

            //Ввод
            Console.WriteLine("\nНапишите номер задачи, чтобы протестировать её");
        }

        protected override bool ReadCommand(string command)
        {
            if (int.TryParse(command, out int selectedProblem))
            {
                if (BuilderProblem.GetProblem(selectedProblem) != null)
                {
                    BuilderScene.SetSceneProblem(BuilderProblem.GetProblem(selectedProblem));
                    return true;
                }
                else
                {
                    ConsoleWriter.ErrorText("Задача отсутствует");
                }
            }
            else
            {
                ConsoleWriter.UnknownCommand();
            }
            return false;
        }
    }
}
