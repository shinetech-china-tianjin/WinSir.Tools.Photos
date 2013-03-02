using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WinSir.Tools.Photos
{
    public class FluentIO
    {
        public static IDirectory BeginFrom(string location) {
            var directoryPath = new DirectoryPath(location);
            if (!directoryPath.IsValid()) {
                throw new InvalidOperationException("Must begin from a directory.");
            }

            return new DirectoryProxy(directoryPath);
        }
    }
}
