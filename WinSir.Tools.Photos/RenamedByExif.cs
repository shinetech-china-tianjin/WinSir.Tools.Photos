using System;
using System.IO;
using ExifWorks;

namespace WinSir.Tools.Photos
{
    public class RenamedByExif
    {
        public string SourceFolder { get; set; }
        public string DestinantionFolder { get; set; }

        public void Execute()
        {
            var files = Directory.GetFiles(SourceFolder, "*.jpg");
            foreach (var file in files)
            {
                try
                {
                    DateTime dt;
                    using (var em = new ExifManager(file))
                    {
                        dt = em.DateTimeOriginal;
                    }

                    if (dt == DateTime.MinValue) continue;

                    var fi = new FileInfo(file);
                    var newName = Path.Combine(DestinantionFolder,
                                               string.Format("{0}.jpg", dt.ToString("yyyy-MM-dd_HH.mm.ss")));
                    fi.MoveTo(newName);
                }
                catch
                {
                }
            }

        }
    }
}