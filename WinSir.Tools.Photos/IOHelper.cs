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
        internal static string FileRename(FileInfoBase fileInfo, string newFileName) {
            var originalFilePath = fileInfo.FullName;
            var oldFilePath = Path.GetDirectoryName(fileInfo.FullName);
            var destinationFilePath = Path.Combine(oldFilePath, newFileName);
            File.Move(originalFilePath, destinationFilePath);
            return destinationFilePath;
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
