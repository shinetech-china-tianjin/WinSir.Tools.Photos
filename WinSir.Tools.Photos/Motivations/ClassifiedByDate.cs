using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WinSir.Tools.Photos;

namespace WinSir.Tools.Photos.Motivations
{
    public class ClassifiedByDate : MotivationBase
    {
        private const string Undefined = "Undefined";
        private IDirectory _directory;
        public ClassifiedByDate(string location) {
            _directory = FluentIO.BeginFrom(location);
        }

        public override void Execute() {
            _directory
                .AllFiles
                .ByFileType<IImageFile>()
                .GroupBy(file => ParseDirectoryName(file))
                .Map(directoryFiles => {
                    var targetDirectory = IOHelper
                        .CreateDirectory(directoryFiles.Key);
                    directoryFiles.Map(file =>
                        file.MoveTo(targetDirectory.FullPath));
                });
        }

        private string ParseDirectoryName(IImageFile file) {
            DateTime datetime;
            var parsedFileName = OSEnvironment.Current.PathHelper
                .GetFileNameWithoutExtension(file.Name)
                .Replace(".", ":")
                .Replace("_", " ");
            if (DateTime.TryParse(parsedFileName, out datetime)) {
                var yearDirectory = datetime.Year.ToString();
                var monthDirectory = datetime.Month.ToString();

                var directoryName = Path.Combile(
                    file.ParentDirectory.FullPath.Location,
                    yearDirectory,
                    monthDirectory);

                return directoryName;
            }

            return Path.Combine(
                file.ParentDirectory.FullPath.Location, 
                Undefined);
        }
    }
}
