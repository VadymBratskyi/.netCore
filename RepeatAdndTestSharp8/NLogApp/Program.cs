using NLog;
using System;

namespace NLogApp
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");

			Logger log = LogManager.GetCurrentClassLogger();

			log.Trace("trace message");
			log.Debug("debug message");
			log.Info("info message");
			log.Warn("warn message");
			log.Error("error message");
			log.Fatal("fatal message");

			Console.ReadKey();

		}
	}
}
