using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace WinSir.Tools.Photos.Tests
{
    public class FileProxyTest
    {
        [Fact]
        public void TestRename() {
            using (var fakeFile = new FakeFileSession()) {
                var newFileName = Guid.NewGuid().ToString();

                var fileProxy = new FileTruck(fakeFile.FakeFile.FullName);
                var newFileProxy = fileProxy.Rename(newFileName);
                Assert.Equal(newFileName, newFileProxy.EntryName);
            }
        }
    }
}
