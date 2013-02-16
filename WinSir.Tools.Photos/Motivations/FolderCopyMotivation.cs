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
            CopyDirectory(CurrentFolder, _destinationFolder);
        }

        private void CopyDirectory(string sourceFolder, string destinationFolder) {
            if (!Directory.Exists(destinationFolder)) {
                Directory.CreateDirectory(destinationFolder);
            }

            foreach (string file in Directory.GetFiles(sourceFolder)) {
                string destination = Path.Combine(destinationFolder, Path.GetFileName(file));
                File.Copy(file, destination);
            }
            if (_includeSubFolder) {
                foreach (string folder in Directory.GetDirectories(sourceFolder)) {
                    string destination = Path.Combine(destinationFolder, Path.GetFileName(folder));
                    CopyDirectory(folder, destination);
                }
            }
        }
    }
}
