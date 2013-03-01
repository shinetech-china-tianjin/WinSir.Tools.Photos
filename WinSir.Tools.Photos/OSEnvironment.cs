using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO.Abstractions;

namespace WinSir.Tools.Photos
{
    internal class OSEnvironment
    {
        internal static OSEnvironment _current;

        internal static OSEnvironment Current {
            get {
                if (_current == null) {
                    _current = new OSEnvironment();
                }
                return _current;
            }
            set {
                _current = value;
            }
        }

        internal virtual PathBase PathHelper {
            get {
                return new PathWrapper();
            }
        }

        internal virtual IFileInfoFactory FileInfoFactory {
            get {
                return new DefaultFileInfoFactory();
            }
        }

        internal virtual IDirectoryInfoFactory DirectoryInfoFactory {
            get {
                return new DefaultDirectoryInfoFactory();
            }
        }
    }
}
