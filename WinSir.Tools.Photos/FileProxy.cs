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

		internal FileProxy (FilePath filePath)
		{
			if (filePath == null) {
                throw new ArgumentNullException("filePath");
			}

            _filePath = filePath;
            _fileInfo = IOHelper.GetFileInfo(filePath);
		}

//		public IFileSystemEntry Rename (string newName)
//		{
//			IOHelper.FileRename (_filePath, newName);
//
//			var baseDirectory = Path.GetDirectoryName (_filePath);
//			var newFilePath = Path.Combine (baseDirectory, newName);
//			return new FileTruck (newFilePath);
//		}

        public string Extension {
            get { throw new NotImplementedException(); }
        }

        public bool IsReadOnly {
            get { throw new NotImplementedException(); }
        }

        public IDirectory ParentDirectory {
            get { throw new NotImplementedException(); }
        }

        public IFile Rename(string newName) {
            throw new NotImplementedException();
        }

        public DateTime CreationTime {
            get {
                throw new NotImplementedException();
            }
            set {
                throw new NotImplementedException();
            }
        }

        public DateTime CreationTimeUtc {
            get {
                throw new NotImplementedException();
            }
            set {
                throw new NotImplementedException();
            }
        }

        public DateTime LastAccessTime {
            get {
                throw new NotImplementedException();
            }
            set {
                throw new NotImplementedException();
            }
        }

        public DateTime LastAccessTimeUtc {
            get {
                throw new NotImplementedException();
            }
            set {
                throw new NotImplementedException();
            }
        }

        public DateTime LastWriteTime {
            get {
                throw new NotImplementedException();
            }
            set {
                throw new NotImplementedException();
            }
        }

        public DateTime LastWriteTimeUtc {
            get {
                throw new NotImplementedException();
            }
            set {
                throw new NotImplementedException();
            }
        }

        public long Size {
            get { throw new NotImplementedException(); }
        }

        public string Name {
            get { throw new NotImplementedException(); }
        }

        public IPath FullPath {
            get { throw new NotImplementedException(); }
        }

        public FileAttributes Attributes {
            get {
                throw new NotImplementedException();
            }
            set {
                throw new NotImplementedException();
            }
        }

        public void Delete() {
            throw new NotImplementedException();
        }

        public IFileSystemEntry MoveTo(DirectoryPath location) {
            throw new NotImplementedException();
        }
    }
}
