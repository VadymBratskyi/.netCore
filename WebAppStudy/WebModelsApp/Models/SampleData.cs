using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebModelsApp.Models
{
    public static class SampleData
    {
        public static void Initialize(MobileContext context) {

            if (!context.Phones.Any())
            {
                context.Phones.AddRange(
                    new Phone
                    {
                        Name = "iPhone 6S",
                        Company = "Apple",
                        Price = 600
                    },
                    new Phone
                    {
                        Name = "Samsung Galaxy Edge",
                        Company = "Samsung",
                        Price = 550
                    },
                    new Phone
                    {
                        Name = "Lumia 950",
                        Company = "Microsoft",
                        Price = 500
                    }
                );

                Company apple = new Company { Name = "Apple", Country = "США" };
                Company microsoft = new Company { Name = "Microsoft", Country = "США" };
                Company google = new Company { Name = "Google", Country = "США" };
                context.Companies.AddRange(new List<Company> { apple, microsoft, google });

                context.Phones2.AddRange(new List<Phone2>
                {
                    new Phone2 { Company = apple, Name = "iPhone 6S", Price = 56000},
                    new Phone2 { Company = apple, Name = "iPhone 5S", Price = 41000},
                    new Phone2 { Company = microsoft, Name = "Lumia 550", Price = 9000},
                    new Phone2 { Company = microsoft, Name = "Lumia 950", Price = 40000},
                    new Phone2 { Company = google, Name = "Nexus 5X", Price = 30000},
                    new Phone2 { Company = google, Name = "Nexus 6P", Price = 50000}
                });

                context.SaveChanges();
            }
        }
    }
}
