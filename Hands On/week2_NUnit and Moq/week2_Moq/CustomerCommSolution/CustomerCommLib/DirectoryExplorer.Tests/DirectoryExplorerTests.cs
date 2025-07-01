using NUnit.Framework;
using Moq;
using MagicFilesLib;
using System.Collections.Generic;

namespace DirectoryExplorer.Tests
{
    [TestFixture]
    public class DirectoryExplorerTests
    {
        private Mock<IDirectoryExplorer> _mockDirectoryExplorer;
        private readonly string _file1 = "file.txt";
        private readonly string _file2 = "file2.txt";

        [OneTimeSetUp]
        public void Init()
        {
            _mockDirectoryExplorer = new Mock<IDirectoryExplorer>();
            _mockDirectoryExplorer.Setup(m => m.GetFiles(It.IsAny<string>()))
                                  .Returns(new List<string> { _file1, _file2 });
        }

        [Test]
        public void GetFiles_ShouldReturnExpectedFiles()
        {
            var files = _mockDirectoryExplorer.Object.GetFiles("any/path");

            Assert.That(files, Is.Not.Null);
            Assert.That(files.Count, Is.EqualTo(2));
            Assert.That(files, Does.Contain(_file1));
        }
    }
}
