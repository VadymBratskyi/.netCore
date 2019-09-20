using RepeatAdndTestSharp8.Models.Delrgates.Bank;
using System;
using System.Collections.Generic;
using System.Text;

namespace RepeatAdndTestSharp8.Models.Delrgates
{
    class TestDelegate
    {
        delegate void Message();
        delegate int Operation(int x, int y);
        delegate T Operation2<T, A, B>(A a, B b);
        delegate void SomeDel(int a, double b);

        public void RunBankDelegate() {
            Account account = new Account(200);
            //account.RegisterHandler(ShowMessage, ShowColorMessage);       
            account.Withdrawn += ShowMessage;
            account.Added += (string sms) => {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(sms);
                Console.ResetColor();
            };
            //account.Error += ShowColorMessage;
            account.Error += delegate(string sms) {//anonim method
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(sms);
                Console.ResetColor();
            };
            account.Withdraw(100);
            account.Withdraw(50);
            account.Put(50);
            account.Withdraw(100);
            account.Withdraw(100);
            account.Withdraw(100);

        }


        public void RunDelegateAsParameter() {
            if (DateTime.Now.Hour < 12)
            {
                ShowMessage(GoodMorning);
            }
            else
            {
                ShowMessage(GoodEvening);
            }

            Console.WriteLine();
            Console.WriteLine("T delegates");
            Operation2<int, int, int> tDel = Add;
            Console.WriteLine(tDel(1,2));
        }

        private void ShowMessage(Message del) {
            del?.Invoke();
        }

        public void RunMultipleMethod() {
            Message ms1 = SomeClass.Hello;
            ms1 += SomeClass.Hello;
            ms1 += SomeClass.HowAreYou;
            ms1();
            Console.WriteLine();
            ms1 -= SomeClass.Hello;
            ms1();

            /*обединять*/
            Console.WriteLine();
            Message ms2 = SomeClass.Hello;
            Message ms3 = SomeClass.HowAreYou;
            Message ms4 = SomeClass.Hello;
            Message ms5 = null;// ms2 + ms3 + ms4;
            ms5?.Invoke();
        }


        public void RunSomeMethod() {
            SomeClass scl = new SomeClass();
            SomeDel sdel = scl.SomeMethod1;            
        }


        public void RunOperatorDelegate() {

            //Operation del1 = Add;
            //Operation del2 = new Operation(Add);

            // присваивание адреса метода через контруктор
            Operation del = Add; // делегат указывает на метод Add
            int result = del(4, 5); // фактически Add(4, 5)
            Console.WriteLine("Add result {0}", result);

            del = Multiply; // теперь делегат указывает на метод Multiply
            result = del(4, 5); // фактически Multiply(4, 5)
            Console.WriteLine("Multiply result {0}", result);

            Math math = new Math();
            del = math.Sum;
            result = del(2,8);
            Console.WriteLine("Math.Sum result {0}", result);
        }

        public void RunTimeDelegte() {

            Message mes;
            if (DateTime.Now.Hour < 12)
            {
                mes = GoodMorning; 
            }
            else
            {
                mes = GoodEvening;
            }
            mes(); 
        }

        private void ShowMessage(string message)
        {
            Console.WriteLine(message);
        }

        private static void ShowColorMessage(string message)
        {
            // Устанавливаем красный цвет символов
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
            // Сбрасываем настройки цвета
            Console.ResetColor();
        }

        private void GoodMorning()
        {
            Console.WriteLine("Good Morning");
        }
        private void GoodEvening()
        {
            Console.WriteLine("Good Evening");
        }

        private static int Add(int x, int y)
        {
            return x + y;
        }
        private static int Multiply(int x, int y)
        {
            return x * y;
        }
    }
}
