using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _001_Problem.Tests
{
    [TestClass]
    public class FileManagerTests
    {
        [TestMethod]
        public void FileManager_FindFileLogByName_1() {

            FileManager fileManager = new FileManager();
            string fileName = "main.log";

            bool exists = fileManager.FindLogFile(fileName);

            Assert.IsTrue(exists);
        
        }
    }
}
