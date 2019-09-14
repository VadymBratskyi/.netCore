using System;
using System.Collections.Generic;
using System.Text;

namespace RepeatAdndTestSharp8.Models.Structures
{
    struct User
    {
        public string name;
        public int age;

        public User(string n, int ag)
        {
            name = n;
            age = ag;
        }
        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {name}  Age: {age}");
        }

    }
}
