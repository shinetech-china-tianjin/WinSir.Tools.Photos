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
		}

//		public IFileSystemEntry Rename (string newName)
//		{
//			IOHelper.FileRename (_filePath, newName);
//
//			var baseDirectory = Path.GetDirectoryName (_filePath);
//			var newFilePath = Path.Combine (baseDirectory, newName);
//			return new FileTruck (newFilePath);
//		}
	}
}
