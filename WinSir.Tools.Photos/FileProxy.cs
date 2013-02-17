using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace WinSir.Tools.Photos
{
    public class FileProxy : IFileIO
    {
        private readonly string _filePath;

        internal FileProxy(string filePath) {
            _filePath = filePath;
            InitializeFile(filePath);
        }

        private void InitializeFile(string filePath) {
            Name = Path.GetFileName(filePath);
        }

        public IBasicIO Rename(string newName) {
            IOHelper.FileRename(_filePath, newName);

            var baseDirectory = Path.GetDirectoryName(_filePath);
            var newFilePath = Path.Combine(baseDirectory, newName);
            return new FileProxy(newFilePath);
        }

        public string Name { get; private set; }
    }
}
