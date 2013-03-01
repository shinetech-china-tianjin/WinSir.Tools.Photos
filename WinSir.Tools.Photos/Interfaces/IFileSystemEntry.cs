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

		DateTime CreationTime { get; }
		DateTime CreationTimeUtc { get; }
		DateTime LastAccessTime { get; }
		DateTime LastAccessTimeUtc { get; }
		DateTime LastWriteTime { get; }
		DateTime LastWriteTimeUtc { get; }

		long Size { get; }
		string Name { get; }
		IPath FullPath { get; }
		FileAttributes Attributes { get; }

		#endregion

		#region Behaviour

		void Delete();
		IFileSystemEntry MoveTo(DirectoryPath location);

		#endregion
	}
}
