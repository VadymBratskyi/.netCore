using System;
using System.Collections.Generic;
using CustomerLibrary;
using CustomerLibrary.CLasses;
using CustomerLibrary.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace MyMoqUnitTest
{
    [TestClass]
    public class CustomerTest
    {

        [TestMethod]
        public void SaveCustomers_WasCalled()
        {
            List<CustomerTDO> list = new List<CustomerTDO>() {

                new CustomerTDO() { FirstName = "Ivan", LastName = "Ivanov" },
                new CustomerTDO() { FirstName = "Petr", LastName = "Petrow" },
                new CustomerTDO() { FirstName = "Fedor", LastName = "Fedorov" }

            };

            Mock<ICustomerService> mock = new Mock<ICustomerService>();
            ICustomerService repository = mock.Object;

            CustomerService service = new CustomerService(repository);

            service.Create(list);
            
            mock.Verify(x => x.Save(It.IsAny<Customer>()));

        }

        [TestMethod]
        public void SaveCustomers_WasCalled_ThreeTimes()
        {
            List<CustomerTDO> list = new List<CustomerTDO>() {
                new CustomerTDO() { FirstName = "Ivan", LastName = "Ivanov" },
                new CustomerTDO() { FirstName = "Petr", LastName = "Petrow" },
                new CustomerTDO() { FirstName = "Fedor", LastName = "Fedorov" }
            };

            Mock<ICustomerService> mock = new Mock<ICustomerService>();
            ICustomerService repository = mock.Object;
            CustomerService service = new CustomerService(repository);

            service.Create(list);

            mock.Verify(x => x.Save(It.IsAny<Customer>()), Times.Exactly(3));

        }

        [TestMethod]
        [ExpectedException(typeof(ApplicationException))]
        public void Create_AddresNotCreated_ExceptioThrow() {


            CustomerTDO customerTDO = new CustomerTDO() {
                FirstName = "Ivan",
                LastName = "Ivanow"
            };

            Mock<ICustomerService> mockServ = new Mock<ICustomerService>();
            Mock<IEmailBuilder> mockBuilder = new Mock<IEmailBuilder>();

            CustomerService customerService = new CustomerService(mockServ.Object, mockBuilder.Object);

            mockBuilder
                .Setup(x => x.From(It.IsAny<CustomerTDO>()))
                .Returns<Address>(null);

            customerService.Create(customerTDO);

        }

        [TestMethod]
        public void Create_AddresCreated_CustomerSaved()
        {
            CustomerTDO customerTDO = new CustomerTDO()
            {
                FirstName = "Ivan",
                LastName = "Ivanow"
            };

            Mock<ICustomerService> mockServ = new Mock<ICustomerService>();
            Mock<IEmailBuilder> mockBuilder = new Mock<IEmailBuilder>();

            CustomerService customerService = new CustomerService(mockServ.Object, mockBuilder.Object);

            mockBuilder
                .Setup(x => x.From(It.IsAny<CustomerTDO>()))
                .Returns(() => new Address(customerTDO));

            customerService.Create(customerTDO);

            mockServ.Verify(x=>x.Save(It.IsAny<Customer>()));

        }


        [TestMethod]
        public void CreateToDb_IdWasCreated() {

            //arrange
            List<CustomerTDO> list = new List<CustomerTDO>() {
                new CustomerTDO() { FirstName = "Ivan", LastName = "Ivanov" },
                new CustomerTDO() { FirstName = "Petr", LastName = "Petrow" },
                new CustomerTDO() { FirstName = "Fedor", LastName = "Fedorov" }
            };

            Mock<ICustomerService> service = new Mock<ICustomerService>();
            Mock<IIdFactory> factory = new Mock<IIdFactory>();

            CustomerService customerService = new CustomerService(service.Object, factory.Object);

            int id = 1;
            factory.Setup(x => x.Create())
                .Returns(() => id)
                .Callback(() => id++);
                        
            //act
            customerService.CreateToDb(list);

            //assert
            service.Verify(x => x.Save(It.IsAny<Customer>()));
            factory.Verify(x => x.Create(), Times.AtLeastOnce());

        }

        [TestMethod]
        public void Create_ShouldSaveUser() {

            CustomerTDO customerTDO = new CustomerTDO()
            {
                FirstName = "Ivan",
                LastName = "Ivanow"
            };

            Mock<ICustomerService> service = new Mock<ICustomerService>();
            Mock<IMailAddressFactory> factory = new Mock<IMailAddressFactory>();

            CustomerService customerService = new CustomerService(service.Object, factory.Object);

            Address address = new Address(customerTDO);

            factory
                .Setup(x => x.TryParse(It.IsAny<string>(), out address))
                .Returns(() => true); ;

            customerService.CreateOutAdress(customerTDO);

            service.Verify(x => x.Save(It.IsAny<Customer>()));

        }

        [TestMethod]
        public void Create_CHeckFullName_FromFirstAndLastName()
        {

            CustomerTDO customerTDO = new CustomerTDO()
            {
                FirstName = "Ivan",
                LastName = "Ivanow"
            };

            Mock<ICustomerService> service = new Mock<ICustomerService>();
            Mock<IFullNameBuilder> builder = new Mock<IFullNameBuilder>();

            CustomerService customerService = new CustomerService(service.Object, builder.Object);

            customerService.CreateFullName(customerTDO);

            builder.Verify(x => x.CreateFullName(
                It.Is<string>(val => val.Equals(customerTDO.FirstName)),
                It.Is<string>(val => val.Equals(customerTDO.LastName))));

        }

        [TestMethod]
        public void Create_CHeckStatusLevel_Bronze_SaveShudBeCalled()
        {

            CustomerTDO customerTDO = new CustomerTDO()
            {
                FirstName = "Ivan",
                LastName = "Ivanow",
                StatusLevel = StatusLevel.Bronze
            };

            Mock<ICustomerService> service = new Mock<ICustomerService>();
            Mock<ICustomerStatusFactory> factory = new Mock<ICustomerStatusFactory>();

            CustomerService customerService = new CustomerService(service.Object, factory.Object);

            factory
                .Setup(x => x.CreateFrom(It.Is<CustomerTDO>(val => val.StatusLevel == StatusLevel.Bronze)))
                .Returns(StatusLevel.Bronze);

            customerService.CreateStatusLevel(customerTDO);

            service.Verify(x => x.Save(It.IsAny<Customer>()));

        }

        [TestMethod]
        public void Create_CHeckStatusLevel_Gold_SaveShudBeCalled()
        {

            CustomerTDO customerTDO = new CustomerTDO()
            {
                FirstName = "Ivan",
                LastName = "Ivanow",
                StatusLevel = StatusLevel.Gold
            };

            Mock<ICustomerService> service = new Mock<ICustomerService>();
            Mock<ICustomerStatusFactory> factory = new Mock<ICustomerStatusFactory>();

            CustomerService customerService = new CustomerService(service.Object, factory.Object);

            factory
                .Setup(x => x.CreateFrom(It.Is<CustomerTDO>(val => val.StatusLevel == StatusLevel.Gold)))
                .Returns(StatusLevel.Gold);

            customerService.CreateStatusLevel(customerTDO);

            service.Verify(x => x.Save(It.IsAny<Customer>()));

        }


    }
}
