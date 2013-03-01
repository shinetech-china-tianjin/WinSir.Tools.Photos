using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WinSir.Tools.Photos
{
    public interface IPath
    {
        Fluent.IO.Path Location { get; }

        bool IsValid();
    }
}
