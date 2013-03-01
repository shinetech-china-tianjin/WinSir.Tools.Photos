using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WinSir.Tools.Photos
{
    public interface IEntryPath
    {
        string Location { get; }

        bool IsValid();
    }
}
