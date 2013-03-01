using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WinSir.Tools.Photos;

namespace WinSir.Tools.Photos.Motivations
{
    public class ClassifiedByDate : IMotivation
    {
        private IDirectory _directory;
        public ClassifiedByDate(string location) {
            _directory = FluentIO.BeginFrom(location);
        }

        public void Execute() {
            _directory
                .AllFiles
                .GroupBy(file => ParseYearFrom(file.Name))
                .Map(yearFiles => {
                    yearFiles.GroupBy(file => ParseMonthFrom(file.Name))
                        .Map(monthFiles => {
                            //var targetDirectory = IOHelper
                            //    .CreateDirectoryUnder(_directory, directoryAndFiles.Key);
                            //directoryAndFiles.Map(file =>
                            //    file.MoveTo(targetDirectory.FullPath));
                        });
                });
        }

        private string ParseYearFrom(string filename) {
            throw new NotImplementedException();
        }

        private string ParseMonthFrom(string filename) {
            throw new NotImplementedException();
        }

        private string ParseFileNameThroughDateTime(string filename) {
            DateTime datetime;
            var parsedFileName = OSEnvironment.Current.PathHelper
                .GetFileNameWithoutExtension(filename)
                .Replace(".", ":")
                .Replace("_", " ");
            if (DateTime.TryParse(parsedFileName, out datetime)) {
                
            }

            throw new NotImplementedException();
        }
    }
}
