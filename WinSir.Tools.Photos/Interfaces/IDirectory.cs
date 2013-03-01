using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WinSir.Tools.Photos
{
	public interface IDirectory : IFileSystemEntry
	{
		IFile Rename (string newName);
		IDirectory MoveTo(IEntryPath newPath);

		IEnumerable<IDirectory> Directories{ get; }
		IEnumerable<IFile> Files{ get; }
	}
}
