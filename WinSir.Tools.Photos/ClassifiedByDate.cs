using System;
using System.Globalization;
using System.IO;

namespace WinSir.Tools.Photos
{
    public class ClassifiedByDate
    {
        public string Folder { get; set; }

        public void Execute()
        {
            foreach (var filePath in Directory.GetFiles(Folder))
            {
                DateTime datetime;
                var fileNameWithoutExtension = Path.GetFileNameWithoutExtension(filePath);
                if (fileNameWithoutExtension != null && DateTime.TryParse(fileNameWithoutExtension.Replace(".", ":").Replace("_", " "), out datetime))
                {
                    MoveFile(filePath, datetime);
                }
            }
        }

        private void MoveFile(string filePath, DateTime datetime)
        {
            MakeYearDir(datetime.Year);
            MakeMonthDir(datetime.Year, datetime.Month);
            var path = Path.Combine(Folder, datetime.Year.ToString(CultureInfo.InvariantCulture),
                                    datetime.Month > 9
                                        ? datetime.Month.ToString(CultureInfo.InvariantCulture)
                                        : "0" + datetime.Month, Path.GetFileName(filePath));
            File.Move(filePath, path);
        }

        private void MakeYearDir(int year)
        {
            var yearDir = Path.Combine(Folder, year.ToString(CultureInfo.InvariantCulture));
            if (Directory.Exists(yearDir))
                return;
            Directory.CreateDirectory(yearDir);
        }

        private void MakeMonthDir(int year, int month)
        {
            var monthDir = Path.Combine(Folder, year.ToString(CultureInfo.InvariantCulture), month > 9 ? month.ToString(CultureInfo.InvariantCulture) : "0" + month);
            if (Directory.Exists(monthDir))
                return;
            Directory.CreateDirectory(monthDir);
        }
    }
}
