using LeetCodeSandBox.Problems;
using LeetCodeSandBox.View;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCodeSandBox
{
    public class Program
    {
        private static void Main()
        {
            while (!BuilderScene.CurrentScene.Equals(BuilderScene.GetSceneExit()))
            {
                BuilderScene.CurrentScene.BaseMain();
            }
        }
    }
}
