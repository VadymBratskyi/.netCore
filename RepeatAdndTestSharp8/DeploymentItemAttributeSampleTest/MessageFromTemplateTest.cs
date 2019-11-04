using System;
using System.IO;
using DeploymentItemAttributeSample;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DeploymentItemAttributeSampleTest
{
    [TestClass]
    public class MessageFromTemplateTest
    {
        [TestMethod]
        [DeploymentItem("Files\\ExamCreatedResult.txt")]
        [DeploymentItem("Files\\ExamCreatedTemplate.txt")]
        public void FromTemplate_PassTestValue_StringFromTemplateReturn()
        {
            MessageFromTemplate messageBuilder = new MessageFromTemplate();
            messageBuilder.TepmplateFolder = ".";

            string expectedResult = File.ReadAllText("ExamCreatedResult.txt");

            string actualResult = messageBuilder.FromTemplate("TestExam", "Beginer", new DateTime(2019, 11, 04));

            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
