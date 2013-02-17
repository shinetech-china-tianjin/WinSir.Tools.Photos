using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace WinSir.Tools.Photos.Motivations
{
    public class FolderCopyMotivation : FolderMotivationBase
    {
        private string _destinationFolder;
        private bool _includeSubFolder;

        public FolderCopyMotivation(string currentFolder, string destinationFolder, bool includeSubFolder = false)
            : base(currentFolder) {
            _destinationFolder = destinationFolder;
            _includeSubFolder = includeSubFolder;
        }
        public override void Execute() {
            FolderCopy(CurrentFolder, _destinationFolder, _includeSubFolder);
        }

        private void FolderCopy(string sourceDirName, string destDirName, bool copySubDirs) {
            DirectoryInfo dir = new DirectoryInfo(sourceDirName);
            DirectoryInfo[] dirs = dir.GetDirectories();

            if (!dir.Exists) {
                throw new DirectoryNotFoundException(
                    "Source directory does not exist or could not be found: "
                    + sourceDirName);
            }

            if (!Directory.Exists(destDirName)) {
                Directory.CreateDirectory(destDirName);
            }

            FileInfo[] files = dir.GetFiles();
            foreach (FileInfo file in files) {
                string temppath = Path.Combine(destDirName, file.Name);
                file.CopyTo(temppath, false);
            }

            if (copySubDirs) {
                foreach (DirectoryInfo subdir in dirs) {
                    string temppath = Path.Combine(destDirName, subdir.Name);
                    FolderCopy(subdir.FullName, temppath, copySubDirs);
                }
            }
        }
    }
}
