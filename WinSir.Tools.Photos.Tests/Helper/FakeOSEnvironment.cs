using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO.Abstractions.TestingHelpers;

namespace WinSir.Tools.Photos.Tests.Helper
{
    internal class FakeOSEnvironment : OSEnvironment
    {
        internal override System.IO.Abstractions.PathBase PathHelper {
            get {
                return new MockPath();
            }
        }

        internal override System.IO.Abstractions.IFileInfoFactory FileInfoFactory {
            get {
                return null;
            }
        }

        internal override System.IO.Abstractions.IDirectoryInfoFactory DirectoryInfoFactory {
            get {
                return base.DirectoryInfoFactory;
            }
        }
    }
}
