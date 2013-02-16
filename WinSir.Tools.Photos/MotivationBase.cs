using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WinSir.Tools.Photos
{
    public abstract class MotivationBase : IMotivation
    {
        protected MotivationBase(string sourceFolder, string destinationFolder) {
            if (string.IsNullOrEmpty(sourceFolder)) {
                throw new ArgumentNullException("sourceFolder");
            }
            if (string.IsNullOrEmpty(destinationFolder)) {
                throw new ArgumentNullException("destinationFolder");
            }

            this.SourceFolder = sourceFolder;
            this.DestinationFolder = destinationFolder;
        }

        protected string SourceFolder { get; set; }
        protected string DestinationFolder { get; set; }

        public abstract void Execute();
    }
}
