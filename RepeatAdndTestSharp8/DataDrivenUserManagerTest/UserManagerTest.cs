using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UserManagerLibrary;

namespace DataDrivenUserManagerTest
{
    [TestClass]
    public class UserManagerTest
    {
        public TestContext TestContext { get; set; }
        private UserManager userManger = new UserManager();

        //DataSource - источник данніх
        //1 - имя провайдера
        //2 - строка подключения или путь к файлу
        //3 - имя таблицы или елемента в XML
        //4 - ка происходит доступ к записям из источникаб попорядку или рандомно
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", 
            "TestDataXML.xml", "User", DataAccessMethod.Sequential)]
        [TestMethod]
        public void UserManager_Add_FromXML()
        {
            var userId = Convert.ToString(TestContext.DataRow["userId"]);
            var phone = Convert.ToString(TestContext.DataRow["phone"]);
            var mail = Convert.ToString(TestContext.DataRow["mail"]);

            var result = userManger.Add(userId, phone, mail);

            Assert.IsTrue(result, "Пользователь не может быть создан");
        }
    }
}
