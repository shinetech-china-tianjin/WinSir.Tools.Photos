using System;
using System.Collections.Generic;
using System.IO.Abstractions;
using System.Linq;
using System.Text;

namespace WinSir.Tools.Photos
{
    public static class PathExtension
    {
        public static string Combile(this PathBase thePath, string path1, string path2, params string[] paths) {
            string result;
            result = thePath.Combine(path1, path2);
            foreach (var path in paths) {
                result = thePath.Combine(result, path);
            }

            return result;
        }
    }
}
