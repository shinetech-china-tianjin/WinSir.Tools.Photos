using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace WinSir.Tools.Photos.Motivations
{
    public sealed class FileCopyMotivation : FileMotivationBase
    {
        private string _destinationFolder;
        public FileCopyMotivation(string currentFilePath, string destinationFolder) : base(currentFilePath) {
            if (string.IsNullOrEmpty(destinationFolder)) {
                throw new ArgumentException("destinationFolder");
            }

            _destinationFolder = destinationFolder;
        }

        public override void Execute() {
            File.Copy(CurrentFilePath, _destinationFolder);
        }
    }
}
