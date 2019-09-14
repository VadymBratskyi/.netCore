using RepeatAdndTestSharp8.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace RepeatAdndTestSharp8.RefTypes
{
    static class SomeClass
    {
        public static void ChangeArray(string[] array)
        {
            array[2] = "5";
            foreach (var ar in array)
            {
                Console.Write(ar);
            }
            Console.WriteLine();
            array = new[] { "4", "5", "6", "7" };
            foreach (var ar in array)
            {
                Console.Write(ar);
            }
        }

        public static void ChangePerson(Person person)
        {
            // сработает
            person.name = "Alice";
            // сработает
            person = new Person { name = "Bill", age = 45 };
            Console.WriteLine(person.name); // Bill
        }

        public static (int sum, int count) GetCorteg(int[] numbers)
        {
            var result = (sum: 0, count: 0);
            for (int i = 0; i < numbers.Length; i++)
            {
                result.sum += numbers[i];
                result.count++;
            }
            return result;
        }

        public static void Sum(ref int a)
        {
            a++;
            Console.WriteLine(a);
        }
    }
}
