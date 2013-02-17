using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace WinSir.Tools.Photos
{
    internal class IOHelper
    {
        internal static void FileRename(string originalFilePath, string newFileName) {
            var oldFilePath = Path.GetDirectoryName(originalFilePath);
            File.Move(originalFilePath, Path.Combine(oldFilePath, newFileName));
        }

        private static FileInfo GetFileInfo(string filePath) {
            return new FileInfo(filePath);
        }
    }
}
