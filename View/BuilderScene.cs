using LeetCodeSandBox.Problems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSandBox.View
{
    public static class BuilderScene
    {
        enum iScenes
        {
            SceneMenu,
            SceneExit,
            SceneProblem
        }

        private static readonly Dictionary<iScenes, Scene> _scenes = new Dictionary<iScenes, Scene>()
        {
            { iScenes.SceneMenu, new SceneMenu() },
            { iScenes.SceneExit, new SceneExit() },
            { iScenes.SceneProblem, new SceneProblem() }
        };

        public static Scene CurrentScene { get; private set; } = new SceneMenu();

        public static SceneMenu GetSceneMenu()
        {
            return (SceneMenu)_scenes[iScenes.SceneMenu];
        }

        public static void SetSceneMenu()
        {
            CurrentScene = _scenes[iScenes.SceneMenu];
        }

        public static SceneExit GetSceneExit()
        {
            return (SceneExit)_scenes[iScenes.SceneExit];
        }

        public static void SetSceneExit()
        {
            CurrentScene = _scenes[iScenes.SceneExit];
        }

        public static SceneProblem GetSceneProblem()
        {
            return (SceneProblem)_scenes[iScenes.SceneProblem];
        }

        public static void SetSceneProblem(Problem problem)
        {
            CurrentScene = _scenes[iScenes.SceneProblem];
            GetSceneProblem().CurrentProblem = problem;
        }
    }
}
