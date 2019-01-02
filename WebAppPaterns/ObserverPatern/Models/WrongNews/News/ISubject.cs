using System;
using System.Collections.Generic;
using System.Text;
using ObserverPatern.Models.WrongNews.Widgest;

namespace ObserverPatern.Models.WrongNews.News
{
    public interface ISubject
    {
        void RegisterObserver(IObserver observer);
        void RemoveObserver(IObserver observer);
        void NotifyObserver();
    }
}
