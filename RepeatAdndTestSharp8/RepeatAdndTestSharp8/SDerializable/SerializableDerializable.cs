using Newtonsoft.Json;
using RepeatAdndTestSharp8.SDerializable;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters.Soap;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Xml.Serialization;

namespace RepeatAdndTestSharp8.SDesiarizable
{
    class SerializableDerializable
    {

        public void GetNewtonsoftSerialization()
        {

            Person person = new Person("Tom", 29, "123");
            person.City = new City("TestCity");
            Console.WriteLine("Объект создан");

            var direct = "C:\\serializeTest";

            DirectoryInfo dir = new DirectoryInfo(direct);

            if (!dir.Exists)
            {
                dir.Create();
            }

            var path = direct + "\\person.json";

            //DataContractJsonSerializer json = new DataContractJsonSerializer(typeof(PersonJson));

            var js = JsonConvert.SerializeObject(person);

            //// получаем поток, куда будем записывать сериализованный объект
            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
            {

                byte[] data = Encoding.Default.GetBytes(js);

                fs.Write(data, 0, data.Length);

                Console.WriteLine("Объект сериализован");
            }

            //// десериализация из файла people.dat
            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
            {
                byte[] data = new byte[fs.Length];

                fs.Read(data, 0, data.Length);

                var txt = Encoding.Default.GetString(data);

                Person newPerson = JsonConvert.DeserializeObject<Person>(txt);

                Console.WriteLine("Объект десериализован");
                Console.WriteLine("Имя: {0} --- Возраст: {1} Счет: null", newPerson.Name, newPerson.Year);
            }
        }        
        public void GetArrNewtonsoftSerialization()
        {

            Person person1 = new Person("Tom", 29, "123");
            person1.City = new City("TestCity");
            Person person2 = new Person("Devid", 21, "456");
            person2.City = new City("MyCity");
            Person[] persons = new Person[] { person1, person2 };

            Console.WriteLine("Объект создан");

            var direct = "C:\\serializeTest";

            DirectoryInfo dir = new DirectoryInfo(direct);

            if (!dir.Exists)
            {
                dir.Create();
            }

            var path = direct + "\\person.json";

            //DataContractJsonSerializer json = new DataContractJsonSerializer(typeof(PersonJson));

            var js = JsonConvert.SerializeObject(persons);

            //// получаем поток, куда будем записывать сериализованный объект
            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
            {

                byte[] data = Encoding.Default.GetBytes(js);

                fs.Write(data, 0, data.Length);

                Console.WriteLine("Объект сериализован");
            }

            //// десериализация из файла people.dat
            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
            {
                byte[] data = new byte[fs.Length];

                fs.Read(data, 0, data.Length);

                var txt = Encoding.Default.GetString(data);

                Person[] newPersons = JsonConvert.DeserializeObject<Person[]>(txt);

                Console.WriteLine("Объект десериализован");
                foreach (Person p in newPersons)
                {
                    Console.WriteLine("Имя: {0} --- Возраст: {1}", p.Name, p.Year);
                }
            }

        }


        public void GetJSONSerialization()
        {

            PersonJson person = new PersonJson("Tom", 29, "123");
            Console.WriteLine("Объект создан");

            var direct = "C:\\serializeTest";

            DirectoryInfo dir = new DirectoryInfo(direct);

            if (!dir.Exists)
            {
                dir.Create();
            }

            var path = direct + "\\person.json";

            DataContractJsonSerializer json = new DataContractJsonSerializer(typeof(PersonJson));

            // получаем поток, куда будем записывать сериализованный объект
            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
            {

                json.WriteObject(fs, person);

                Console.WriteLine("Объект сериализован");
            }

            // десериализация из файла people.dat
            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
            {
                PersonJson newPerson = (PersonJson)json.ReadObject(fs);

                Console.WriteLine("Объект десериализован");
                Console.WriteLine("Имя: {0} --- Возраст: {1} Счет: null", newPerson.Name, newPerson.Year);
            }
        }
        public void GetArrJSONSerialization()
        {

            PersonJson person1 = new PersonJson("Tom", 29, "123");          
            PersonJson person2 = new PersonJson("Bill", 25, "456");
            PersonJson[] people = new PersonJson[] { person1, person2 };

            Console.WriteLine("Объект создан");

            var direct = "C:\\serializeTest";

            DirectoryInfo dir = new DirectoryInfo(direct);

            if (!dir.Exists)
            {
                dir.Create();
            }
            var path = direct + "\\person.json";


            DataContractJsonSerializer json = new DataContractJsonSerializer(typeof(PersonJson[]));

            // получаем поток, куда будем записывать сериализованный объекты
            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
            {

                json.WriteObject(fs, people);

                Console.WriteLine("Объекты сериализованы");
            }

            // десериализация из файла people.dat
            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
            {
                PersonJson[] newPersons = (PersonJson[])json.ReadObject(fs);

                foreach (PersonJson p in newPersons)
                {
                    Console.WriteLine("Имя: {0} --- Возраст: {1}", p.Name, p.Year);
                }
            }
        }


        public void GetXMLSerialization()
        {

            Person person = new Person("Tom", 29, "123");
            person.City = new City("Kiev");
            Console.WriteLine("Объект создан");

            var direct = "C:\\serializeTest";

            DirectoryInfo dir = new DirectoryInfo(direct);

            if (!dir.Exists)
            {
                dir.Create();
            }

            var path = direct + "\\person.xml";

            XmlSerializer xml = new XmlSerializer(typeof(Person));
            // получаем поток, куда будем записывать сериализованный объект
            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
            {

                xml.Serialize(fs, person);

                Console.WriteLine("Объект сериализован");
            }

            // десериализация из файла people.dat
            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
            {
                Person newPerson = (Person)xml.Deserialize(fs);

                Console.WriteLine("Объект десериализован");
                Console.WriteLine("Имя: {0} --- Возраст: {1} Счет: {2}", newPerson.Name, newPerson.Year, newPerson.accNumber);
            }
        }
        public void GetArrXMLSerialization()
        {

            Person person1 = new Person("Tom", 29, "123");
            person1.City = new City("Kiev");
            Person person2 = new Person("Bill", 25, "456");
            person2.City = new City("Shepetivka");
            Person[] people = new Person[] { person1, person2 };

            Console.WriteLine("Объект создан");

            var direct = "C:\\serializeTest";

            DirectoryInfo dir = new DirectoryInfo(direct);

            if (!dir.Exists)
            {
                dir.Create();
            }
            var path = direct + "\\person.xml";


            XmlSerializer xml = new XmlSerializer(typeof(Person[]));
            // получаем поток, куда будем записывать сериализованный объекты
            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
            {

                xml.Serialize(fs, people);

                Console.WriteLine("Объекты сериализованы");
            }

            // десериализация из файла people.dat
            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
            {
                Person[] newPersons = (Person[])xml.Deserialize(fs);

                foreach (Person p in newPersons)
                {
                    Console.WriteLine("Имя: {0} --- Возраст: {1}", p.Name, p.Year);
                }
            }
        }


        public void GetSOAPSerialization()
        {

            Person person = new Person("Tom", 29, "123");
            Console.WriteLine("Объект создан");

            var direct = "C:\\serializeTest";

            DirectoryInfo dir = new DirectoryInfo(direct);

            if (!dir.Exists)
            {
                dir.Create();
            }

            var path = direct + "person.soap";

            SoapFormatter soap = new SoapFormatter();
            // получаем поток, куда будем записывать сериализованный объект
            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
            {

                soap.Serialize(fs, person);

                Console.WriteLine("Объект сериализован");
            }

            // десериализация из файла people.dat
            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
            {
                Person newPerson = (Person)soap.Deserialize(fs);

                Console.WriteLine("Объект десериализован");
                Console.WriteLine("Имя: {0} --- Возраст: {1} Счет: {2}", newPerson.Name, newPerson.Year, newPerson.accNumber);
            }
        }
        public void GetArrSOAPSerialization()
        {

            Person person1 = new Person("Tom", 29, "123");
            Person person2 = new Person("Bill", 25, "456");

            Person[] people = new Person[] { person1, person2 };

            Console.WriteLine("Объект создан");

            var direct = "C:\\serializeTest";

            DirectoryInfo dir = new DirectoryInfo(direct);

            if (!dir.Exists)
            {
                dir.Create();
            }
            var path = direct + "\\person.soap";


            SoapFormatter soap = new SoapFormatter();
            // получаем поток, куда будем записывать сериализованный объекты
            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
            {

                soap.Serialize(fs, people);

                Console.WriteLine("Объекты сериализованы");
            }

            // десериализация из файла people.dat
            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
            {
                Person[] newPersons = (Person[])soap.Deserialize(fs);

                foreach (Person p in newPersons)
                {
                    Console.WriteLine("Имя: {0} --- Возраст: {1}", p.Name, p.Year);
                }
            }
        }


        public void GetBinarySerialization() {

            Person person = new Person("Tom", 29, "123");
            Console.WriteLine("Объект создан");

            var direct = "C:\\serializeTest";

            DirectoryInfo dir = new DirectoryInfo(direct);

            if (!dir.Exists)
            {
                dir.Create();
            }

            var path = direct + "person.dat";

            BinaryFormatter bf = new BinaryFormatter();
            // получаем поток, куда будем записывать сериализованный объект
            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate)) {

                bf.Serialize(fs, person);

                Console.WriteLine("Объект сериализован");
            }

            // десериализация из файла people.dat
            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
            {
                Person newPerson = (Person)bf.Deserialize(fs);

                Console.WriteLine("Объект десериализован");
                Console.WriteLine("Имя: {0} --- Возраст: {1} Счет: {2}" , newPerson.Name, newPerson.Year, newPerson.accNumber);
            }
        }
        public void GetArrBinarySerialization()
        {

            Person person1 = new Person("Tom", 29, "123");
            Person person2 = new Person("Bill", 25, "456");

            Person[] people = new Person[] { person1, person2 };

            Console.WriteLine("Объект создан");

            var direct = "C:\\serializeTest";

            DirectoryInfo dir = new DirectoryInfo(direct);
            
            if (!dir.Exists) {
                dir.Create();
            }
            var path = direct + "\\person.dat";


            BinaryFormatter bf = new BinaryFormatter();
            // получаем поток, куда будем записывать сериализованный объекты
            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
            {

                bf.Serialize(fs, people);

                Console.WriteLine("Объекты сериализованы");
            }

            // десериализация из файла people.dat
            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
            {
                Person[] newPersons = (Person[])bf.Deserialize(fs);

                foreach (Person p in newPersons)
                {
                    Console.WriteLine("Имя: {0} --- Возраст: {1}", p.Name, p.Year);
                }
            }
        }

    }
}
