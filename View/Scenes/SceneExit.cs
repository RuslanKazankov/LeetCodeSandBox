using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSandBox.View
{
    public class SceneExit : Scene
    {
        protected override void Main()
        {
            Console.Clear();
        }

        protected override bool ReadCommand(string command)
        {
            return false;
        }
    }
}
