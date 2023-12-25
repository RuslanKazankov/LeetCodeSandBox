using LeetCodeSandBox.Problems;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSandBox.View
{
    public abstract class Scene
    {
        protected abstract void Main();
        protected abstract bool ReadCommand(string command);

        public void BaseMain()
        {
            Console.Clear();
            Console.WriteLine("#Console: Введите \"/exit\" для выхода из программы, \"/menu\" для перехода в меню\n");
            Main();

            while (!Commands()) ;
        }

        //true - смена сцены
        private bool Commands()
        {
            Console.Write(">");
            string command = Console.ReadLine();
            if (command == "/exit")
            {
                BuilderScene.SetSceneExit();
                return true;
            }
            else if (command == "/menu")
            {
                BuilderScene.SetSceneMenu();
                return true;
            }
            else if (false) //Другие консольные команды
            {

            }
            else
            {
                return ReadCommand(command);
            }
        }
    }
}
