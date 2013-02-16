using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WinSir.Tools.Photos.Motivations
{
    public abstract class FolderMotivationBase : IMotivation
    {
        protected FolderMotivationBase(string currentFolder)
        {
            this.CurrentFolder = currentFolder;
        }

        public abstract void Execute();

        protected string CurrentFolder { get; set; }
    }
}
