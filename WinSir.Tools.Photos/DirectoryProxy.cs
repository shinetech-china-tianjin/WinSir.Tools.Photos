using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.IO.Abstractions;

namespace WinSir.Tools.Photos
{
	public class DirectoryProxy// : System.IO.Abstractions.DirectoryInfoBase, IDirectory
	{
//		public DirectoryTruck (string directoryPath):base(new DirectoryInfo(directoryPath))
//		{
//
//		}

		public static IDirectory FromDirectoryInfo (DirectoryInfo directory)
		{
			throw new NotImplementedException ();
		}

		public IDirectory LetDirectoryFiles (Action<IFile> command)
		{
			throw new NotImplementedException ();
		}

		public IFileSystemEntry Rename (string newName)
		{
			throw new NotImplementedException ();
		}

		public string EntryName {
			get { throw new NotImplementedException (); }
		}

		public Fluent.IO.Path EntryPath {
			get { throw new NotImplementedException (); }
		}

		public IDirectory MoveTo (Fluent.IO.Path newPath)
		{
			throw new NotImplementedException ();
		}

		public IDirectory EmptyChildrenFile ()
		{
			throw new NotImplementedException ();
		}

		public IDirectory EmptyChildrenFolder ()
		{
			throw new NotImplementedException ();
		}

		public IEnumerable<IFile> Files {
			get {
				throw new NotImplementedException ();
			}
		}
	}
}
