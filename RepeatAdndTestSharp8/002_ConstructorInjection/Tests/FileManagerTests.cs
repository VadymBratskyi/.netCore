using _002_ConstructorInjection.DataAccessObject;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002_ConstructorInjection.Tests
{
    [TestClass]
    public class FileManagerTests
    {
        [TestMethod]
        public void FileManager_FindFileLogByName_2() {

            IDataAccessObject dataAccessObject = new StubFileDataObject();
            FileManager fileManager = new FileManager(dataAccessObject); //Dependency Injection
            string fileName = "main.log";

            bool exist = fileManager.FindLogFile(fileName);

            Assert.IsTrue(exist, "File {0} wasn't found.", fileName);

        }

    }
}
