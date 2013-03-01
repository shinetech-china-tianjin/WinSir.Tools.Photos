using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Abstractions;
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

        internal static FileInfoBase GetFileInfo(FilePath filePath) {
            var fileFactory = OSEnvironment.Current.FileInfoFactory;
            return fileFactory.FromFileName(filePath.Location);
        }

        internal static DirectoryInfoBase GetDirectoryInfo(DirectoryPath directoryPath) {
            var directoryFactory = OSEnvironment.Current.DirectoryInfoFactory;
            return directoryFactory.FromDirectoryName(directoryPath.Location);
        }
    }
}
