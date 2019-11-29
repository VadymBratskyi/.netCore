using CustomerLibrary.CLasses;
using CustomerLibrary.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;

namespace CustomerLibrary
{
   
    public class CustomerService
    {

        private ICustomerService customerService;
        private IWorkStationSettings workStationSettings;
		private IEmailBuilder emailBuilder;
        private IIdFactory idFactory;
        private IMailAddressFactory mailAddressFactory;
        private IFullNameBuilder fullNameBuilder;
        private ICustomerStatusFactory statusFactory;

		public void CustomerRepository_Notify(object sender, NotifyEventArgs args) {
			mailAddressFactory.CreateMessage(args.CustomName);
		}


        public CustomerService(ICustomerService service)
        {
            customerService = service;

		}

		public CustomerService(ICustomerService service, IWorkStationSettings workStation)
		{
			customerService = service;
			workStationSettings = workStation;
		}


		public CustomerService(ICustomerService service, IIdFactory idfactory)
        {
            customerService = service;
            idFactory = idfactory;
        }

        public CustomerService(ICustomerService service, IMailAddressFactory mailFactory)
        {
            customerService = service;
            mailAddressFactory = mailFactory;

			customerService.Notify += CustomerRepository_Notify;
        }

        public CustomerService(ICustomerService service, IEmailBuilder email) {
            customerService = service;
            emailBuilder = email;
        }

        public CustomerService(ICustomerService service, IFullNameBuilder builder)
        {
            customerService = service;
            fullNameBuilder = builder;
        }

        public CustomerService(ICustomerService service, ICustomerStatusFactory statusFactory)
        {
            customerService = service;
            this.statusFactory = statusFactory;
        }
		
        public void Create(IEnumerable<CustomerTDO> customers) {
            foreach (CustomerTDO customer in customers) {
                customerService.Save(new Customer() {
                    FirstName = customer.FirstName,
                    LastName = customer.LastName,
                    Email = new Address(customer)
                });
            }
        }

		public void CreateWithProperty(CustomerTDO customerTDO)
		{

			Customer customer = new Customer() { 
				FirstName = customerTDO.FirstName, 
				LastName = customerTDO.LastName 
			};

			int? id = workStationSettings.WorksationId;

			if (!id.HasValue) {
				throw new ApplicationException();
			}

			customer.WorkStationId = id;

			//проверка установлено свойство
			customerService.LocalTimeZone = TimeZone.CurrentTimeZone.StandardName;

			customerService.Save(customer);


		}

		public void Create(CustomerTDO customerTDO) {

            Customer customer = new Customer() { FirstName = customerTDO.FirstName, LastName = customerTDO.LastName };

            customer.Email = emailBuilder.From(customerTDO);

            if (customer.Email == null) {
                throw new ApplicationException("Emails isn't be null!!");
            }

            customerService.Save(customer);

        }

        public void CreateToDb(IEnumerable<CustomerTDO> customerTDOs) {

            foreach (var customer in customerTDOs) {

                Customer newCustomer = new Customer(customer.FirstName, customer.LastName);
                newCustomer.Id = idFactory.Create();
                customerService.Save(newCustomer);
            }

        }

        public void CreateOutAdress(CustomerTDO customerTDO)
        {

            Customer customer = new Customer(customerTDO.FirstName, customerTDO.LastName);

            Address address;

            mailAddressFactory.TryParse(customerTDO.Email, out address);

            if (address == null)
            {
                throw new ApplicationException("Emails isn't be null!!");
            }

            customer.Email = address;

            customerService.Save(customer);

        }

		public void CreateAdressAndEvent(CustomerTDO customerTDO)
		{
			Customer customer = new Customer("Vadim", "Bratskyi");

			customerService.Save(customer);
		}

		public void CreateCustomerAdress(CustomerTDO customerTDO)
		{
			try
			{				
				Customer customer = new Customer(customerTDO.FirstName, customerTDO.LastName);
				var addres = statusFactory.CreateAdreesFrom(customerTDO);

				customer.Email = addres;

				customerService.Save(customer);
			}
			catch (ArgumentNullException ex) {
				throw new CustomerCreateException(ex.Message);
			}

		}

		public void CreateFullName(CustomerTDO customerTDO)
        {
            var fullName = fullNameBuilder.CreateFullName(customerTDO.FirstName, customerTDO.LastName);
            
            Customer customer = new Customer(fullName);
            
            customerService.Save(customer);

        }


        public void CreateStatusLevel(CustomerTDO customerTDO)
        {     
            Customer customer = new Customer(customerTDO.FirstName, customerTDO.LastName);

            customer.StatusLevel = statusFactory.CreateFrom(customerTDO);

            switch (customer.StatusLevel) {
                case StatusLevel.Gold:
                    Debug.WriteLine("customerService.SaveExtended");
                    customerService.SaveExtended(customer);
                    break;
                default:
                    Debug.WriteLine("customerService.Save");
                    customerService.Save(customer);
                    break;
            }

            customerService.Save(customer);

        }

    }

	public class CustomerCreateException : Exception 
	{
		public CustomerCreateException(string message) : base(message) { 
			
		}

	}

}
