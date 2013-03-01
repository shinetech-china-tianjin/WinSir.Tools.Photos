using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace WinSir.Tools.Photos
{
	public interface IFileSystemEntry
	{
		#region Metadata Properties

		DateTime CreationTime { get; set; }
		DateTime CreationTimeUtc { get; set; }
		DateTime LastAccessTime { get; set; }
		DateTime LastAccessTimeUtc { get; set; }
		DateTime LastWriteTime { get; set; }
		DateTime LastWriteTimeUtc { get; set; }

		long Size { get; }
		string Name { get; }
		IPath FullPath { get; }
		FileAttributes Attributes { get; set; }

		#endregion

		#region Behaviour

		void Delete();
		IFileSystemEntry MoveTo(DirectoryPath location);

		#endregion
	}
}
