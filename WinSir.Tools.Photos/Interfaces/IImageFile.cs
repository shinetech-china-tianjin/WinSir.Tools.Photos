using ExifLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WinSir.Tools.Photos
{
    public interface IImageFile : IFile, IFileType
    {
        T GetTagValue<T>(ExifTags tag);
    }
}
