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
		Fluent.IO.Path FullPath { get; }
		FileAttributes Attributes { get; set; }
		DateTime CreationTime { get; set; }
		DateTime CreationTimeUtc { get; set; }
		DateTime LastAccessTime { get; set; }
		DateTime LastAccessTimeUtc { get; set; }
		DateTime LastWriteTime { get; set; }
		DateTime LastWriteTimeUtc { get; set; }
		long Size { get; }
		string Name { get; }

		#endregion

		#region Behaviour

		void Delete();

		#endregion
	}
}
