using _005_LocalFactoryMethod.DataAccessObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _005_LocalFactoryMethod.Tests
{

    class FileManagerUnderTest : FileManager {

        protected override IDataAccessObject CreateDataAccessObject()
        {
            return new StubFileDataObject();
        }

    }

    [TestClass]
    public class FileManagerTest
    {
        [TestMethod]
        public void FileManager_FinfFileLogByName_5()
        {
            var fileManager = new FileManagerUnderTest();
            string fileName = "main.log";

            bool exist = fileManager.FindlogFile(fileName);

            Assert.IsTrue(exist, "File {0} wasn't found.", fileName);
        }
    }
}
