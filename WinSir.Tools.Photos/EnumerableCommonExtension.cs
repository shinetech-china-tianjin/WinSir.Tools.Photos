using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WinSir.Tools.Photos
{
    public static class EnumerableCommonExtension
    {
        public static IEnumerable<T> ByFileType<T>(this IEnumerable<IFile> files) where T : IFileType {
            return files.OfType<T>();
        }

        public static IEnumerable<T> Map<T>(this IEnumerable<T> list, Action<T> action) {
            foreach (var item in list) {
                action(item);
                yield return item;
            }
        }
    }
}
