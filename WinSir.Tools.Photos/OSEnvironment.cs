using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO.Abstractions;

namespace WinSir.Tools.Photos
{
    internal class OSEnvironment
    {
        internal PathBase PathHelper {
            get {
                return new PathWrapper();
            }
        }

        internal IFileInfoFactory FileInfoFactory {
            get {
                return new DefaultFileInfoFactory();
            }
        }

        internal IDirectoryInfoFactory DirectoryInfoFactory {
            get {
                return new DefaultDirectoryInfoFactory();
            }
        }
    }
}
