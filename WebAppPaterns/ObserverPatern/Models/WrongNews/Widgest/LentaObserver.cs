using System;
using System.Collections.Generic;
using System.Text;
using ObserverPatern.Models.WrongNews.News;

namespace ObserverPatern.Models.WrongNews.Widgest
{

    public class LentaObserver : IWidget //IObserver
    {

        private string _lenta;

        public event GetDisplay SendDisplay;
        //private ISubject _subject;
     
        //public LentaObserver(ISubject subject)
        //{
        //    _subject = subject;
        //    _subject.RegisterObserver(this);
        //}

        //public void Update(string twitter, string lenta, string tv)
        //{
        //    _lenta =  $"Lenta: {lenta}";
        //}

        public void Update(object sender, NewsAggregateArgs e)
        {
            _lenta = $"Lenta: {e.Lenta}";
            if (SendDisplay != null)
            {
                SendDisplay(this, Display());
            }
        }

        public string Display()
        {
            return _lenta;
        }


        //public void RemoveFromSubject()
        //{
        //    _subject.RemoveObserver(this);
        //}
    }
}
