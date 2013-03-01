using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WinSir.Tools.Photos
{
    public static class EnumerableExtension
    {
        public static IEnumerable<T> ByFileType<T>(this IEnumerable<IFile> files) where T : IFileType {
            return files.OfType<T>();
        }
    }
}
