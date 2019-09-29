using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace RepeatAdndTestSharp8.StringBuilder
{
    class TestString
    {

        public void GetRegexMail()
        {
            string pattern = @"^(?("")(""[^""]+?""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
                             @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9]{2,17}))$";
            while (true)
            {
                Console.WriteLine("Введите адрес электронной почты");
                string email = Console.ReadLine();

                if (Regex.IsMatch(email, pattern, RegexOptions.IgnoreCase))
                {
                    Console.WriteLine("Email подтвержден");
                    break;
                }
                else
                {
                    Console.WriteLine("Некорректный email");
                }
            }

        }

        public void GetRegex()
        {
            string s = "Бык тупогуб, тупогубенький бычок, у быка губа бела была тупа";
            Regex regex = new Regex(@"туп(\w*)");
            MatchCollection matches = regex.Matches(s);
            if (matches.Count > 0)
            {
                foreach (Match match in matches)
                    Console.WriteLine(match.Value);
            }
            else
            {
                Console.WriteLine("Совпадений не найдено");
            }
            Console.WriteLine();
            Regex regex2 = new Regex(@"\w*губ\w*");
            MatchCollection matches2 = regex2.Matches(s);
            if (matches2.Count > 0)
            {
                foreach (Match match in matches2)
                    Console.WriteLine(match.Value);
            }
            else
            {
                Console.WriteLine("Совпадений не найдено");
            }
            Console.WriteLine();
            string s2 = "456-435-2318";
            Regex regex3 = new Regex(@"\d{3}-\d{3}-\d{4}");
            if (regex3.IsMatch(s2))
            {
                Console.WriteLine(s2);
            }

            Console.WriteLine();
            var s3 = "222-222-2222";
            //Regex regex4 = new Regex("[a-v]{5}");
            //Regex regex4 = new Regex(@"[2]*-[0-9]{3}-\d{4}");
            Regex regex4 = new Regex(@"[2|3]{3}-[0-9]{3}-\d{4}");
            //Regex regex4 = new Regex("[0-9]{5}-[0-9]{3}-[0-9]{4}");
            if (regex4.IsMatch(s3))
            {
                Console.WriteLine(s3);
            }

            Console.WriteLine();
            var s4 = "222.222.2222";
            Regex regex5 = new Regex(@"[2|3]{3}\.[0-9]{3}\.\d{4}");
            if (regex4.IsMatch(s4))
            {
                Console.WriteLine(s4);
            }

            Console.WriteLine();
            string s5 = "Мама  мыла  раму. ";
            Console.WriteLine(s5);
            string pattern = @"\s+";
            string target = " ";
            Regex regex6 = new Regex(pattern);
            string result = regex6.Replace(s5, target);
            Console.WriteLine(result);
        }

        public void GetStringBuilder()
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder("Привет мир");
            Console.WriteLine("Длина строки: {0}", sb.Length);
            Console.WriteLine("Емкость строки: {0}", sb.Capacity);

            sb.Append(" Руководство");
            Console.WriteLine("Длина строки: {0}", sb.Length); // 22
            Console.WriteLine("Емкость строки: {0}", sb.Capacity); // 32

            sb.Append(" по C#");
            Console.WriteLine("Длина строки: {0}", sb.Length); // 28
            Console.WriteLine("Емкость строки: {0}", sb.Capacity); // 32


            sb.Append("!");
            sb.Insert(7, "компьютерный ");
            Console.WriteLine(sb);

            // заменяем слово
            sb.Replace("мир", "world");
            Console.WriteLine(sb);

            // удаляем 13 символов, начиная с 7-го
            sb.Remove(7, 13);
            Console.WriteLine(sb);

            // получаем строку из объекта StringBuilder
            string s = sb.ToString();
            Console.WriteLine(s);

            Console.WriteLine("Длина строки: {0}", sb.Length); 
            Console.WriteLine("Емкость строки: {0}", sb.Capacity); 

        }


        public void CompareTwoStr()
        {
            string str1 = "123";
            string str2 = "123";

            Console.WriteLine(str1 + " " + str1.GetHashCode());
            Console.WriteLine(str2 + " " + str2.GetHashCode());
        } 
        
    }
}
