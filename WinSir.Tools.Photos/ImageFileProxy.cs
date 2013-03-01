using ExifLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WinSir.Tools.Photos.Interfaces;

namespace WinSir.Tools.Photos
{
    public class ImageFileProxy : FileProxy, IImageExifInfoProvider
    {
        public ImageFileProxy(FilePath filePath) : base(filePath) { }

        public T GetTagValue<T>(ExifTags tag) {
            T result;
            var exifReader = new ExifReader(FullPath.Location);
            if (exifReader.GetTagValue<T>(tag, out result)) {
                return result;
            }

            return default(T);
        }
    }
}
