using System;
using System.Collections.Generic;
using System.Text;

namespace RepeatAdndTestSharp8.Models.Delrgates.Bank
{
    class Account
    {
        public delegate void AccountStateHandler(string message);
        public delegate void AccountErrorHandler(string message);

        AccountStateHandler _del;
        AccountErrorHandler _err;

        public event AccountStateHandler Withdrawn;
        public event AccountStateHandler Added;
        public event AccountStateHandler Error;
        int _sum;

        public Account(int sum)
        {
            _sum = sum;
            Console.WriteLine($"CurrentSum {CurrentSum}");
        }

        public void RegisterHandler(AccountStateHandler del, AccountErrorHandler err)
        {
            _del += del; // добавляем делегат
            _err += err; // добавляем делегат
        }
        // Отмена регистрации делегата
        public void UnregisterHandler(AccountStateHandler del)
        {
            _del -= del; // удаляем делегат
        }

        //public void RegisterHandler(AccountStateHandler del) {
        //    _del = del;
        //    //Delegate.Combine
        //    //Delegate.Remove
        //}

        public int CurrentSum => _sum;
        public void Put(int sum)
        {
            _sum += sum;
            if (Added != null) {
                Added($"На счет поступило {sum}");
            }
                
        }

        public void Withdraw(int sum)
        {
            if (sum <= _sum)
            {
                _sum -= sum;
                //if (_del != null)
                //{
                //    _del($"Сумма {sum} снята со счета");
                //}
                if (Withdrawn != null)
                {
                    Withdrawn($"Сумма {sum} снята со счета");
                }
            }
            else {
                //if (_err != null)
                //{
                //    _err($"Недостаточно денег на счете");
                //}
                if (Error != null)
                {
                    Error($"Недостаточно денег на счете");
                }
            }
        }
    }
}
