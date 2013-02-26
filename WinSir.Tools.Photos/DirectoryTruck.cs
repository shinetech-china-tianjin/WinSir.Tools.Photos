using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WinSir.Tools.Photos
{
    public class DirectoryTruck : IDirectory
    {
        public IDirectory LetDirectoryFiles(Action<IFile> command) {
            throw new NotImplementedException();
        }

        public IFileSystemEntry Rename(string newName) {
            throw new NotImplementedException();
        }


        public string EntryName {
            get { throw new NotImplementedException(); }
        }


        public Fluent.IO.Path EntryPath {
            get { throw new NotImplementedException(); }
        }

        public EntryMetadata Metadata {
            get { throw new NotImplementedException(); }
        }
    }
}
