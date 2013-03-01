using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Abstractions;
using System.Linq;
using System.Text;

namespace WinSir.Tools.Photos
{
    internal class DefaultDirectoryInfoFactory : IDirectoryInfoFactory
    {
        public DirectoryInfoBase FromDirectoryName(string directoryName) {
            var di = new DirectoryInfo(directoryName);
            return new DirectoryInfoWrapper(di);
        }
    }
}
