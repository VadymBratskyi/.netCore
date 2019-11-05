using _004_InterfaceInjection.DataAccessObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceInjection.Tests
{
    [TestClass]
    public class FileManagerTest
    {
        [TestMethod]
        public void FileManager_FinfFileLogByName_4()
        {
            IDataAccessObject dataAccess = new StubFileDataObject();
            FileManager fileManager = new FileManager();
            string fileName = "main.log";

            bool exist = fileManager.FindlogFile(fileName, dataAccess); //Dependency Injection

            Assert.IsTrue(exist, "File {0} wasn't found.", fileName);
        }
    }
}
