using System;
using System.Collections.Generic;
using System.Text;
using ObserverPatern.Models.WrongNews.Widgest;

namespace ObserverPatern.Models.WrongNews.News
{
    public class NewsAggregateArgs
    {
        public string Twitter { get; private set; }
        public string Lenta { get; private set; }
        public string Tv { get; private set; }

        public NewsAggregateArgs(string twitter, string lenta, string tv)
        {
            Twitter = twitter;
            Lenta = lenta;
            Tv = tv;
        }
    }

    public delegate void GetDisplay(object sender, string display);

    public delegate void NewsChangedEventHandler(object sender, NewsAggregateArgs args);

    public class NewsAggregator //: ISubject
    {
        private static Random _random;
        public List<string> _displays;
        //private List<IObserver> _observers;

        public NewsAggregator()
        {
            _random = new Random();
            //_observers = new List<IObserver>();
        }

        public event NewsChangedEventHandler NewsChanged;

        public string GetTwitterNews()
        {
            var news = new List<string>()
            {
                "News from Twitter number 1",
                "News from Twitter number 2",
                "News from Twitter number 3"
            };

            return news[_random.Next(3)];
        }

        public string GetLentaNews()
        {
            var news = new List<string>()
            {
                "News from Lenta number 1",
                "News from Lenta number 2",
                "News from Lenta number 3"
            };

            return news[_random.Next(3)];
        }

        public string GetTvNews()
        {
            var news = new List<string>()
            {
                "News from TV number 1",
                "News from TV number 2",
                "News from TV number 3"
            };

            return news[_random.Next(3)];
        }

        public void GetDisplayTxt(object sender, string txt)
        {
            _displays.Add(txt);
        }


        //public void RegisterObserver(IObserver observer)
        //{
        //    _observers.Add(observer);
        //}

        //public void RemoveObserver(IObserver observer)
        //{
        //    _observers.Remove(observer);
        //}

        //public void NotifyObserver()
        //{
        //    string twitter = GetTwitterNews();
        //    string lenta = GetLentaNews();
        //    string tv = GetTvNews();

        //    foreach (var observer in _observers)
        //    {
        //        observer.Update(twitter, lenta, tv);
        //    }
        //}

        //public List<IObserver> GetObservers()
        //{
        //    return _observers;
        //}

        public void NewNewsAvailable()
        {
            _displays = new List<string>();

            string twitter = GetTwitterNews();
            string lenta = GetLentaNews();
            string tv = GetTvNews();

            if(NewsChanged != null){
                NewsChanged(this, new NewsAggregateArgs(twitter, lenta, tv));
            }

            //NotifyObserver();
        }

    }
}
