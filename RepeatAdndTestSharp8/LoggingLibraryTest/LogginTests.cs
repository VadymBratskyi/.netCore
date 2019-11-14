using System;
using LoggingLibrary;
using LoggingLibraryTest.Mocks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LoggingLibraryTest
{
    [TestClass]
    public class LogginTests
    {
        private Logger logger;

        private MockLoggingConfiguration mockLoggingConfiguration;
        private MockMessageBodyGenerator mockMessageBodyGenerator;
        private MockMessageHeaderGenerator mockMessageHeaderGenerator;
        private MockSensitiveDataScruber mockSensitiveDataScruber;

        [TestInitialize]
        public void Initialize()
        {
            mockLoggingConfiguration = new MockLoggingConfiguration();
            mockMessageBodyGenerator = new MockMessageBodyGenerator();
            mockMessageHeaderGenerator = new MockMessageHeaderGenerator();
            mockSensitiveDataScruber = new MockSensitiveDataScruber();

            logger = new Logger(mockSensitiveDataScruber, 
                mockMessageBodyGenerator,
                mockMessageHeaderGenerator, 
                mockLoggingConfiguration);
        }


        [TestMethod]
        public void Logger_CreateEntry_SensetiveDataShutBeScrubed()
        {
            logger.CreteEntry("Test log", LogLevel.Error);

            Assert.IsTrue(mockSensitiveDataScruber.ClearMessageWasCalled);
        }

        [TestMethod]
        public void Logger_CreateEntry_HederCreated()
        {
            logger.CreteEntry("Test log", LogLevel.Error);

            Assert.IsTrue(mockMessageHeaderGenerator.CreateHeaderWasCalled);
        }

        [TestMethod]
        public void Logger_CreateEntry_BodyCreated()
        {
            logger.CreteEntry("Test log", LogLevel.Error);

            Assert.IsTrue(mockMessageBodyGenerator.CreateBodyWasCalled);
        }

    }
}
