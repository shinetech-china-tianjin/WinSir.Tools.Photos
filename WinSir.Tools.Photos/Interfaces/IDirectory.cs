using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WinSir.Tools.Photos
{
	public interface IDirectory : IFileSystemEntry
	{
		IFile Rename (string newName);

		IEnumerable<IDirectory> Directories{ get; }
		IEnumerable<IFile> Files{ get; }
		IEnumerable<IFile> AllFiles { get; }

		IDirectory CreateDirectory(string directoryName);
	}
}
