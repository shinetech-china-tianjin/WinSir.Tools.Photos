using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WinSir.Tools.Photos
{
    public sealed class DirectoryPath : EntryPathBase
    {
        public DirectoryPath(string location)
            : base(location) { }

        public override bool IsValid() {
            throw new NotImplementedException();
        }
    }
}
