using _003_PropertyInjection.DataAccessObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003_PropertyInjection.Tests
{
    [TestClass]
    public class FileManagerTests
    {

        [TestMethod]
        public void FileManager_FinfFileLogByName_3() {

            IDataAccessObject accessObject = new StubFileDataObject();
            FileManager fileManager = new FileManager();
            fileManager.DataAccessObject = accessObject; //Dependency Injection

            string fileName = "main.log";

            bool exist = fileManager.FindLogFile(fileName);

            Assert.IsTrue(exist, "File {0} wasn't found.", fileName);

        }

    }
}
