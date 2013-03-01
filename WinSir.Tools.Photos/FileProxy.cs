using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Abstractions;
using System.Linq;
using System.Text;

namespace WinSir.Tools.Photos
{
    public class FileProxy : IFile
    {
        private readonly FilePath _filePath;
        private readonly FileInfoBase _fileInfo;

        internal FileProxy(string filePath) : this(new FilePath(filePath)) { }

        internal FileProxy(FilePath filePath) {
            if (filePath == null) {
                throw new ArgumentNullException("filePath");
            }

            _filePath = filePath;
            _fileInfo = IOHelper.GetFileInfo(filePath);
        }

        public string Extension { get { return _fileInfo.Extension; } }

        public bool IsReadOnly { get { return _fileInfo.IsReadOnly; } }

        public IDirectory ParentDirectory { get { return DirectoryProxy.Build(_fileInfo.Directory); } }


        public DateTime CreationTime { get { return _fileInfo.CreationTime; } }

        public DateTime CreationTimeUtc { get { return _fileInfo.CreationTimeUtc; } }

        public DateTime LastAccessTime { get { return _fileInfo.LastAccessTime; } }

        public DateTime LastAccessTimeUtc { get { return _fileInfo.LastAccessTimeUtc; } }

        public DateTime LastWriteTime { get { return _fileInfo.LastWriteTime; } }

        public DateTime LastWriteTimeUtc { get { return _fileInfo.LastWriteTimeUtc; } }

        public long Size { get { return _fileInfo.Length; } }

        public string Name { get { return _fileInfo.Name; } }

        public IEntryPath FullPath { get { return new FilePath(_fileInfo.FullName); } }

        public FileAttributes Attributes { get { return _fileInfo.Attributes; } }

        public void Delete() {
            _fileInfo.Delete();
        }
        public IFile Rename(string newName) {
            var destinationFilePath = IOHelper.FileRename(_fileInfo, newName);
            return new FileProxy(destinationFilePath);
        }

        public IFileSystemEntry MoveTo(IEntryPath location) {
            throw new NotImplementedException();
        }
    }
}
