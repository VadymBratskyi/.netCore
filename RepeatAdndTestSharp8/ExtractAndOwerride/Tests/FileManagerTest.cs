using _006_ExtractAndOwerride;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _006_ExtractAndOwerride.Tests
{

    class FileManagerUnderTest : FileManager {

        public override List<string> GetFiles()
        {
            return new List<string>
            {
                "file1.txt",
                "file2.log",
                "file3.exe",
                "main.log"
            };
        }

    }

    [TestClass]
    public class FileManagerTest
    {
        [TestMethod]
        public void FileManager_FinfFileLogByName_6()
        {
            var fileManager = new FileManagerUnderTest();
            string fileName = "main.log";

            bool exist = fileManager.FindlogFile(fileName);

            Assert.IsTrue(exist, "File {0} wasn't found.", fileName);
        }
    }
}
