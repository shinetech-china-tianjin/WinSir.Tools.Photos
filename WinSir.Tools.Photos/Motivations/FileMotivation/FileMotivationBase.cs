using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WinSir.Tools.Photos.Motivations
{
    public abstract class FileMotivationBase : IMotivation
    {
        protected FileMotivationBase(string currentFilePath)
        {
            this.CurrentFilePath = currentFilePath;
        }

        public abstract void Execute();

        protected string CurrentFilePath { get; set; }
    }
}
