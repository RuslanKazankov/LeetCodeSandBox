using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSandBox.Problems
{
    public abstract class Problem
    {
        public abstract int Number { get; }
        public abstract string Title { get; }
        public string FullTitle { get => Number + ". " + Title; }
        protected abstract string EngDescription { get; }
        protected abstract string RusDescription { get; }

        private bool originalDicripttion = false;
        public string Description() {

            if (originalDicripttion)
                return EngDescription;

            else return RusDescription;
        }
        public void Translate() { originalDicripttion = !originalDicripttion; }
        /// <summary>
        /// null - ошибка ввода
        /// </summary>
        /// <returns></returns>
        public abstract string Test();

    }
}
