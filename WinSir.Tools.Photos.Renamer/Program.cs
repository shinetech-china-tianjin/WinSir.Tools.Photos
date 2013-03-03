
using System;
using System.IO;

namespace WinSir.Tools.Photos.Renamer
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = Environment.CurrentDirectory;
            if (args != null && args.Length > 0 && Directory.Exists(args[0])) path = args[0];
            (new RenamedByExif { SourceFolder = path, DestinantionFolder = path }).Execute();
        }
    }
}
