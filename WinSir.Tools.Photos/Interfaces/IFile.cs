using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WinSir.Tools.Photos
{
	public interface IFile : IFileSystemEntry
	{
		string Extension{ get; }
		bool IsReadOnly { get; }

		IDirectory ParentDirectory { get; }
		IFile Rename (string newName);
	}
}
