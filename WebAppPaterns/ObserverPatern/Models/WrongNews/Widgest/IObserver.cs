using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPatern.Models.WrongNews.Widgest
{
    public interface IObserver
    {
        void Update(string twitter, string lenta, string tv);

        string Display();

        void RemoveFromSubject();
    }
}
