using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.IO.Abstractions;

namespace WinSir.Tools.Photos
{
	public class DirectoryProxy// : System.IO.Abstractions.DirectoryInfoBase, IDirectory
	{
        internal static IDirectory BuildByPath(DirectoryPath directoryPath) {
            throw new NotImplementedException();
        }
    }
}
