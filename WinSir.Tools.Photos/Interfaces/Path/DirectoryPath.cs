using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WinSir.Tools.Photos
{
    public sealed class DirectoryPath : IPath
    {
        public DirectoryPath(string location) {

        }

        public string Location {
            get { throw new NotImplementedException(); }
        }
        
        public bool IsValid() {
            throw new NotImplementedException();
        }
    }
}
