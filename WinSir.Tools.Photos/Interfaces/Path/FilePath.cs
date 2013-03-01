using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WinSir.Tools.Photos
{
    public sealed class FilePath : IPath
    {
        public FilePath(string location) {

        }

        public Fluent.IO.Path Location {
            get { throw new NotImplementedException(); }
        }

        public bool IsValid() {
            throw new NotImplementedException();
        }
    }
}
