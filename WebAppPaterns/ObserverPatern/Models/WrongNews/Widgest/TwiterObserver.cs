using System;
using System.Collections.Generic;
using System.Text;
using ObserverPatern.Models.WrongNews.News;

namespace ObserverPatern.Models.WrongNews.Widgest
{
    public class TwiterObserver : IWidget //IObserver
    {
        private string _twitter;
        public event GetDisplay SendDisplay;
        //private ISubject _subject;

        //public TwiterObserver(ISubject subject)
        //{
        //    _subject = subject;
        //    _subject.RegisterObserver(this);
        //}

        //public void Update(string twitter, string lenta, string tv)
        //{
        //    _twitter = $"Twitter: {twitter}";
        //}

        public void Update(object sender, NewsAggregateArgs e)
        {
            _twitter = $"Twitter: {e.Twitter}";
            if (SendDisplay != null)
            {
                SendDisplay(this, Display());
            }
        }

        public string Display()
        {
            return _twitter;
        }

        //public void RemoveFromSubject()
        //{
        //    _subject.RemoveObserver(this);
        //}
    }
}
