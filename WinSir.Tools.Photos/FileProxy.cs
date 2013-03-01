using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace WinSir.Tools.Photos
{
	public class FileProxy// : IFile
	{
		private readonly string _filePath;
		private readonly FileInfo _file;

		internal FileProxy (string filePath)
		{
			_filePath = filePath;
			InitializeFile (filePath);
		}

		private void InitializeFile (string filePath)
		{
			EntryName = Path.GetFileName (filePath);
		}

//		public IFileSystemEntry Rename (string newName)
//		{
//			IOHelper.FileRename (_filePath, newName);
//
//			var baseDirectory = Path.GetDirectoryName (_filePath);
//			var newFilePath = Path.Combine (baseDirectory, newName);
//			return new FileTruck (newFilePath);
//		}

		public string EntryName { get; private set; }

		public Fluent.IO.Path EntryPath {
			get { throw new NotImplementedException (); }
		}

		public IDirectory ParentDirectory { get { return DirectoryProxy.FromDirectoryInfo(_file.Directory); } }

		public string DirectoryName { get { return _file.DirectoryName; } }

		public long Size { get { return _file.Length; } }

		public string Extension { get { return _file.Extension; } }

		public bool IsReadOnly { get { return _file.IsReadOnly; } }
		
		public DateTime LastAccessTime { get { return _file.LastAccessTime; } }

		public DateTime LastAccessTimeUtc { get { return _file.LastAccessTimeUtc; } }
		
		public DateTime LastWriteTime { get { return _file.LastWriteTime; } }
		
		public DateTime LastWriteTimeUtc { get { return _file.LastWriteTimeUtc; } }
	}
}
