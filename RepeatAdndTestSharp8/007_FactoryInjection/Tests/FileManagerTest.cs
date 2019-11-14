using _007_FactoryInjection.DataAccessObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _007_FactoryInjection.Tests
{
    [TestClass]
    public class FileManagerTest
    {
        [TestMethod]
        public void FileManager_FinfFileLogByName_7()
        {
            DataAccessFactory.SetDataAccessObject(new StubFileDataObject());

            var fileManager = new FileManager();
            string fileName = "main.log";

            bool exist = fileManager.FindlogFile(fileName);

            Assert.IsTrue(exist, "File {0} wasn't found.", fileName);
        }
    }
}
