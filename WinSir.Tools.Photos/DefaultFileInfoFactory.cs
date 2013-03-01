using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Abstractions;
using System.Linq;
using System.Text;

namespace WinSir.Tools.Photos
{
    internal class DefaultFileInfoFactory : IFileInfoFactory
    {
        public FileInfoBase FromFileName(string fileName) {
            var fi = new FileInfo(fileName);
            return new FileInfoWrapper(fi);
        }
    }
}
