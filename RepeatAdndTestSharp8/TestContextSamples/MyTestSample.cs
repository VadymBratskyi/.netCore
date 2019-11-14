using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestContextSamples
{
    [TestClass]
    public class MyTestSample
    {
        //TestContext хранит информацию о текущем юнит тесте
        //При тест. веб сервисов хранитurl
        //При тест. ASP.NET прилож - предоставляет доступ к ASP страницам
        //При использовании Data Driven тестов придоставляет доступ к источнику данных
        public TestContext TestContext { get; set; }

        [TestMethod]
        public void TestMethod1()
        {
            TestContext.WriteLine("TestRunDirectory {0}", TestContext.TestRunDirectory);
            TestContext.WriteLine("TestName {0}", TestContext.TestName);
            TestContext.WriteLine("CurrentTestOutcome {0}", TestContext.CurrentTestOutcome);
        }

        [TestCleanup]
        public void TestCleanup()
        {
            TestContext.WriteLine("TestName (Cleanup) {0}", TestContext.TestName);
            TestContext.WriteLine("CurrentTestOutcome (Cleanup) {0}", TestContext.CurrentTestOutcome);
        }
    }
}
