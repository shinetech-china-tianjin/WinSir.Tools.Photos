using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WinSir.Tools.Photos
{
    public class DirectoryProxy : IDirectoryIO
    {
        public IDirectoryIO LetDirectoryFiles(Action<IFileIO> command) {
            throw new NotImplementedException();
        }

        public IBasicIO Rename(string newName) {
            throw new NotImplementedException();
        }


        public string Name {
            get { throw new NotImplementedException(); }
        }
    }
}
