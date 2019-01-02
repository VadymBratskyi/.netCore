using System;
using System.Collections.Generic;
using System.Text;
using ObserverPatern.Models.WrongNews.News;

namespace ObserverPatern.Models.WrongNews.Widgest
{
    public class TvObserver : IWidget //IObserver
    {
        private string _tv;
        public event GetDisplay SendDisplay;
        //private ISubject _subject;

        //public TvObserver(ISubject subject)
        //{
        //    _subject = subject;
        //    _subject.RegisterObserver(this);
        //}


        //public void Update(string twitter, string lenta, string tv)
        //{
        //    _tv = $"TV: {tv}";
        //}

        public void Update(object sender, NewsAggregateArgs e)
        {
            _tv = $"TV: {e.Tv}";
            if (SendDisplay != null)
            {
                SendDisplay(this, Display());
            }
        }

        public string Display()
        {
            return _tv;
        }

        //public void RemoveFromSubject()
        //{
        //    _subject.RemoveObserver(this);
        //}
    }
}
