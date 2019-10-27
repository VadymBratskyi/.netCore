using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace ThreadingLibrary.Threading
{
    public class RepeatThread
    {
        public void GetThreadInfo() {

            //for (var i = 0; i < 10; i++) {
            //    Console.WriteLine(i);
            //    Thread.Sleep(1000);
            //}
            Thread thr = Thread.CurrentThread;

            //получаем имя потока
            Console.WriteLine("Имя потока: {0}", thr.Name);
            thr.Name = "Метод Main";
            Console.WriteLine("Имя потока: {0}", thr.Name);

            Console.WriteLine("Запущен ли поток: {0}", thr.IsAlive);
            Console.WriteLine("Приоритет потока: {0}", thr.Priority);
            Console.WriteLine("Статус потока: {0}", thr.ThreadState);

            // получаем домен приложения
            Console.WriteLine("Домен приложения: {0}", Thread.GetDomain().FriendlyName);

        }

    }
}
