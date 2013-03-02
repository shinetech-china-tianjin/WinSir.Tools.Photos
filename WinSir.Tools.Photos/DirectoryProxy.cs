using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.IO.Abstractions;

namespace WinSir.Tools.Photos
{
	public class DirectoryProxy : IDirectory
	{
		private readonly DirectoryPath _directoryPath;
		private readonly DirectoryInfoBase _directoryInfo;

		internal DirectoryProxy(string directoryPath) : this(new DirectoryPath(directoryPath)) { }

		internal DirectoryProxy(DirectoryPath directoryPath) {
			if (directoryPath == null) {
				throw new ArgumentNullException("filePath");
			}

			_directoryPath = directoryPath;
			_directoryInfo = IOHelper.GetDirectoryInfo(directoryPath);
		}

		public IFile Rename(string newName) {
			throw new NotImplementedException();
		}

		public IDirectory MoveTo(IEntryPath newPath) {
			throw new NotImplementedException();
		}

		public IEnumerable<IDirectory> Directories {
			get { throw new NotImplementedException(); }
		}

		public IEnumerable<IFile> Files {
			get { throw new NotImplementedException(); }
		}

		public IEnumerable<IFile> AllFiles {
			get { throw new NotImplementedException(); }
		}

		public IDirectory CreateDirectory(string directoryName) {
			throw new NotImplementedException();
		}

		public DateTime CreationTime {
			get { throw new NotImplementedException(); }
		}

		public DateTime CreationTimeUtc {
			get { throw new NotImplementedException(); }
		}

		public DateTime LastAccessTime {
			get { throw new NotImplementedException(); }
		}

		public DateTime LastAccessTimeUtc {
			get { throw new NotImplementedException(); }
		}

		public DateTime LastWriteTime {
			get { throw new NotImplementedException(); }
		}

		public DateTime LastWriteTimeUtc {
			get { throw new NotImplementedException(); }
		}

		public long Size {
			get { throw new NotImplementedException(); }
		}

		public string Name {
			get { throw new NotImplementedException(); }
		}

		public IEntryPath FullPath {
			get { throw new NotImplementedException(); }
		}

		public FileAttributes Attributes {
			get { throw new NotImplementedException(); }
		}

		public void Delete() {
			throw new NotImplementedException();
		}

		IFileSystemEntry IFileSystemEntry.MoveTo(IEntryPath location) {
			throw new NotImplementedException();
		}
	}
}
