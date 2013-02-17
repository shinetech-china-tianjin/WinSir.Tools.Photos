using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace WinSir.Tools.Photos.Motivations.FileMotivation
{
    public class FileDeleteMotivation : FileMotivationBase
    {
        public FileDeleteMotivation(string currentFilePath)
            : base(currentFilePath) {
        }

        public override void Execute() {
            File.Delete(CurrentFilePath);
        }
    }
}
