using System;
using LoggingLibrary;
using LoggingLibrary.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace LoggingLibraryTestMoq
{
    [TestClass]
    public class LogginTests
    {
        private Logger logger;

        private Mock<ILoggingConfiguration> mockLoggingConfiguration;
        private Mock<IMessageBodyGenerator> mockMessageBodyGenerator;
        private Mock<IMessageHeaderGenerator> mockMessageHeaderGenerator;
        private Mock<ISensitiveDataScruber> mockSensitiveDataScruber;

        [TestInitialize]
        public void Initialize()
        {
            mockLoggingConfiguration = new Mock<ILoggingConfiguration>();
            mockMessageBodyGenerator = new Mock<IMessageBodyGenerator>();
            mockMessageHeaderGenerator = new Mock<IMessageHeaderGenerator>();
            mockSensitiveDataScruber = new Mock<ISensitiveDataScruber>();

            logger = new Logger(mockSensitiveDataScruber.Object,
                mockMessageBodyGenerator.Object,
                mockMessageHeaderGenerator.Object,
                mockLoggingConfiguration.Object);
        }


        [TestMethod]
        public void Logger_CreateEntry_SensetiveDataShutBeScrubed()
        {
            mockSensitiveDataScruber.Setup(s => s.ClearMessage(It.IsAny<string>()));

            logger.CreteEntry("Test log", LogLevel.Error);

            //Assert.IsTrue(mockSensitiveDataScruber.ClearMessageWasCalled);
            mockSensitiveDataScruber.VerifyAll();
        }

        [TestMethod]
        public void Logger_CreateEntry_HederCreated()
        {
            mockMessageHeaderGenerator.Setup(m => m.CreateHeader(It.IsAny<LogLevel>()));

            logger.CreteEntry("Test log", LogLevel.Error);

            //Assert.IsTrue(mockMessageHeaderGenerator.CreateHeaderWasCalled);
            mockMessageHeaderGenerator.VerifyAll();
        }

        [TestMethod]
        public void Logger_CreateEntry_BodyCreated()
        {
            mockMessageBodyGenerator.Setup(b => b.CreateBody(It.IsAny<string>()));

            logger.CreteEntry("Test log", LogLevel.Error);

            //Assert.IsTrue(mockMessageBodyGenerator.CreateBodyWasCalled);
            mockMessageBodyGenerator.VerifyAll();
        }

    }
}
