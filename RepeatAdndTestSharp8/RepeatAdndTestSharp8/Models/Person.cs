using System;
using System.Collections.Generic;
using System.Text;

namespace RepeatAdndTestSharp8.Models
{
    class Person : ICloneable, IComparable<Person>//IComparable
    {
        public string name { get; set; }
        public int age { get; set; }
        public Company work { get; set; }
        public static void GetName() { }

        public object Clone()
        {
            //return new Person() { age = age, name = name };
            //return MemberwiseClone(); //same with up только для простых типов
            Company comp = new Company() { Name = work.Name };//глуокое копирование
            return new Person()
            {
                age = age,
                name = name,
                work = comp
            };
        }

        public int CompareTo(Person other)
        {
            return name.CompareTo(other.name);
        }

        //public int CompareTo(object obj)
        //{
        //    Person p = obj as Person;
        //    if (p != null)
        //    {
        //        return name.CompareTo(p.name);
        //    }
        //    else {
        //        throw new Exception("Can't compare");
        //    }
        //}
    }
}
