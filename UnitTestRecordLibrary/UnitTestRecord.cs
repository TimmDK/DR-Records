using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RecordLibrary;

namespace UnitTestRecordLibrary
{
    [TestClass]
    public class UnitTestRecord
    {
        private Record _r1;

        [TestInitialize]
        public void Init()
        {
            _r1 = new Record();
        }

        [TestMethod]
        public void TestRecordTitle()
        {

            _r1.Title = "Our first album";

            Assert.AreEqual(_r1.Title, "Our first album");
            Assert.ThrowsException<ArgumentNullException>(() => _r1.Title = null);
            Assert.ThrowsException<ArgumentNullException>(() => _r1.Title = "");
        }

        [TestMethod]
        public void TestRecordArtist()
        {
            _r1.Artist = "Ghost Iris";

            Assert.AreEqual(_r1.Artist, "Ghost Iris");
            Assert.ThrowsException<ArgumentNullException>(() => _r1.Artist = null);
            Assert.ThrowsException<ArgumentNullException>(() => _r1.Artist = "");
        }

        [TestMethod]
        public void TestRecordReleaseYear()
        {
            _r1.ReleaseYear = 2020;

            Assert.AreEqual(_r1.ReleaseYear, 2020);
            Assert.ThrowsException<ArgumentOutOfRangeException>((() => _r1.ReleaseYear = -1 ));
        }
    }
}
