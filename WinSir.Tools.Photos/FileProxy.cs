using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WinSir.Tools.Photos
{
    public class FileProxy : IFileIO
    {
        private readonly string _filePath;

        internal FileProxy(string filePath) {
            _filePath = filePath;
        }

        public IBasicIO Rename(string newName) {
            throw new NotImplementedException();
        }
    }
}
