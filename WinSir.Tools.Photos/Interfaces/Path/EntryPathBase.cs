using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WinSir.Tools.Photos
{
    public abstract class EntryPathBase : IEntryPath
    {
        public EntryPathBase(string location) {

        }

        public string Location { get; protected set; }

        public abstract bool IsValid();
    }
}
