using BankLibrary.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace BankLibrary.Models
{
    public abstract class Account : IAccount
    {

        //Событие, возникающее при выводе денег
        protected internal event AccountStateHandler Withdrawed;
        // Событие возникающее при добавление на счет
        protected internal event AccountStateHandler Added;
        // Событие возникающее при открытии счета
        protected internal event AccountStateHandler Opened;
        // Событие возникающее при закрытии счета
        protected internal event AccountStateHandler Closed;
        // Событие возникающее при начислении процентов
        protected internal event AccountStateHandler Calculated;
        // Событие возникающее при ошибки
        protected internal event AccountStateHandler Error;

        protected int _id;
        static int counter = 0;

        protected decimal _sum; // Переменная для хранения суммы
        protected int _percentage; // Переменная для хранения процента

        protected int _days = 0; // время с момента открытия счета

        public Account(decimal sum, int percentage)
        {
            _sum = sum;
            _percentage = percentage;
            _id = ++counter;
        }

        // Текущая сумма на счету
        public decimal CurrentSum => _sum;
        public int Percentage => _percentage;
        public int Id => _id;

        private void CallEvent(AccountEventArgs args, AccountStateHandler hendler) {
            if (hendler != null && args != null) {
                hendler(this, args);
            }
        }

        // вызов отдельных событий. Для каждого события определяется свой витуальный метод
        protected virtual void OnOpened(AccountEventArgs e)
        {           
            CallEvent(e, Opened);
        }
        protected virtual void OnWithdrawed(AccountEventArgs e)
        {
            CallEvent(e, Withdrawed);
        }
        protected virtual void OnAdded(AccountEventArgs e)
        {
            CallEvent(e, Added);
        }
        protected virtual void OnClosed(AccountEventArgs e)
        {
            CallEvent(e, Closed);
        }
        protected virtual void OnCalculated(AccountEventArgs e)
        {
            CallEvent(e, Calculated);
        }
        protected virtual void OnError(AccountEventArgs e)
        {
            CallEvent(e, Error);
        }

        public virtual void Put(decimal sum)
        {
            _sum += sum;
            OnAdded(new AccountEventArgs("На счет поступило " + sum, sum));
        }

        public virtual decimal Withdraw(decimal sum)
        {
            decimal result = 0;
            if (sum <= _sum)
            {
                _sum -= sum;
                result = sum;
                OnWithdrawed(new AccountEventArgs("Сумма " + sum + " снята со счета " + _id, sum));
            }
            else
            {
                OnError(new AccountEventArgs("Недостаточно денег на счете " + _id, 0));
            }
            return result;
        }

        // открытие счета
        protected internal virtual void Open()
        {
            OnOpened(new AccountEventArgs("Открыт новый счет! Id счета: " + this._id, this._sum));
        }

        // закрытие счета
        protected internal virtual void Close()
        {
            OnClosed(new AccountEventArgs("Счет " + _id + " закрыт.  Итоговая сумма: " + CurrentSum, CurrentSum));
        }

        protected internal void IncrementDays()
        {
            _days++;
        }

        // начисление процентов
        protected internal virtual void Calculate()
        {
            decimal increment = _sum * _percentage / 100;
            _sum = _sum + increment;
            OnCalculated(new AccountEventArgs("Начислены проценты в размере: " + increment, increment));
        }
    }
}
