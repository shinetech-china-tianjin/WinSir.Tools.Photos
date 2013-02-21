using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace WinSir.Tools.Photos
{
    public class FileTruck : IFile
    {
        private readonly string _filePath;

        internal FileTruck(string filePath) {
            _filePath = filePath;
            InitializeFile(filePath);
        }

        private void InitializeFile(string filePath) {
            EntryName = Path.GetFileName(filePath);
        }

        public IFileSystemEntry Rename(string newName) {
            IOHelper.FileRename(_filePath, newName);

            var baseDirectory = Path.GetDirectoryName(_filePath);
            var newFilePath = Path.Combine(baseDirectory, newName);
            return new FileTruck(newFilePath);
        }

        public string EntryName { get; private set; }


        public string EntryPath {
            get { throw new NotImplementedException(); }
        }

        public EntryMetadata Metadata {
            get { throw new NotImplementedException(); }
        }
    }
}
