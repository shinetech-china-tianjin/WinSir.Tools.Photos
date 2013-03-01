using ExifLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WinSir.Tools.Photos.Interfaces
{
    public interface IImageExifInfoProvider : IFileType
    {
        T GetTagValue<T>(ExifTags tag);
    }
}
