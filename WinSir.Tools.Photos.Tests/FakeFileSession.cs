using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace WinSir.Tools.Photos.Tests
{
    public class FakeFileSession : IDisposable
    {
        private const string TestFileDirectoryName = "TestFiles";
        private readonly string TestDirectoryPath = generateSessionFileLocation();
        private readonly string _sessionFileName;
        private string _sessionFilePath;

        public FakeFileSession() {
            if (!Directory.Exists(TestDirectoryPath)) {
                Directory.CreateDirectory(TestDirectoryPath);
            }

            _sessionFileName = Guid.NewGuid().ToString();
            _sessionFilePath = Path.Combine(TestDirectoryPath, _sessionFileName);

            CreateSessionFile();
        }

        private void CreateSessionFile() {
            using (var fs = new FileStream(_sessionFilePath, FileMode.CreateNew)) {
                using (var sw = new StreamWriter(fs)) {
                    sw.Write(_sessionFileName);
                }
            }

            FakeFile = new FileInfo(_sessionFilePath);
        }

        private static string generateSessionFileLocation() {
            var baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
            var testsDirectory = Path.Combine(baseDirectory, TestFileDirectoryName);

            return testsDirectory;
        }

        public FileInfo FakeFile { get; private set; }

        public void Dispose() {
            if (File.Exists(_sessionFilePath)) {
                File.Delete(_sessionFilePath);
            }
        }
    }
}
