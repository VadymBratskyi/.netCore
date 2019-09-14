using System;
using System.Collections.Generic;
using System.Text;

namespace RepeatAdndTestSharp8.Models
{
     class Client
        {
            public Phone[] phones;
            public const string K = "";
            private static int counter = 0;
            public Client()
            {
                counter++;
                phones = new Phone[3];
            }

            public static void DisplayCounter()
            {
                Console.WriteLine($"Создано {counter} объектов Client");
            }

            public void DisplayPhones()
            {
                foreach (var ph in phones)
                {
                    Console.WriteLine(ph?.Number);
                }

            }

            public Phone this[int index]
            {
                get
                {
                    return phones[index];
                }

                set
                {
                    phones[index] = value;
                }
            }

        }
}
