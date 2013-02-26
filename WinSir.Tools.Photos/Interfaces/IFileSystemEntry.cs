using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WinSir.Tools.Photos
{
    public interface IFileSystemEntry
    {
        IFileSystemEntry Rename(string newName);

        string EntryName { get; }
        Fluent.IO.Path EntryPath { get; }

        EntryMetadata Metadata { get; }
    }
}
