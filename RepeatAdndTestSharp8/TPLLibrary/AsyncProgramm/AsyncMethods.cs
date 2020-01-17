using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TPLLibrary.AsyncProgramm
{
	public class AsyncPrograming
	{

		public void RunAsyncWithCancellation() {

			CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();
			CancellationToken cancellationToken = cancellationTokenSource.Token;
			FactorialAsyncCancel(6, cancellationToken);
			Thread.Sleep(5000);
			cancellationTokenSource.Cancel();

		}

		private async void FactorialAsyncCancel(int n, CancellationToken cancellationToken) {

			if (cancellationToken.IsCancellationRequested) {
				return;
			}
			await Task.Run(() => FactorialWithCancell(n, cancellationToken));			
		}

		public void RunStreamAsync() {

			ReadWriteAsync();

			Console.WriteLine("Некоторая работа RunStreamAsync");
		}

		private async void ReadWriteAsync() {

			var flName = "hello.txt";

			string s = "Hello world! One step at a time";

			using (StreamWriter writer = new StreamWriter(flName, false)) {
				await writer.WriteLineAsync(s);
			}

			using (StreamReader reader = new StreamReader(flName)) {
				string result = await reader.ReadToEndAsync();
				Console.WriteLine(result);
			}

		}

		public void RunFactorialAsync() {

			FactorialAsync(2); // вызов асинхронного метода
			FactorialAsync(5); // вызов асинхронного метод
							   //Factorial();
			Factorial2Async(4);
			RunTaskFactorialAsync();

			Console.WriteLine("Введите число: ");
			int n = Int32.Parse(Console.ReadLine());
			Console.WriteLine($"Квадрат числа равен {n * n}");

		}

		public void RunArrayFactorialAsync()
		{
			ArreyFactorialAsync();
		}

		public void RunTaskWithExseption() {

			Task tsk = null;	

			try {
				tsk = Task.Run(() => {
					Console.WriteLine("Task work");
					throw new Exception($"Thread {Task.CurrentId} Some exceptio");
				});
				
				tsk.Wait();
			}
			catch (Exception ex) {
				Console.ForegroundColor = ConsoleColor.Red;			
				Console.WriteLine(tsk.Exception.InnerException.Message);
				Console.ForegroundColor = ConsoleColor.White;
			}

			Task allTasks = null;

			try
			{
				Task t1 = Task.Run(() =>
				{
					Console.WriteLine("Task work1");
					throw new Exception($"Thread {Task.CurrentId} Some exceptio");
				});
				Task t2 = Task.Run(() =>
				{
					Console.WriteLine("Task work2");
					throw new Exception($"Thread {Task.CurrentId} Some exceptio");
				});
				Task t3 = Task.Run(() =>
				{
					Console.WriteLine("Task work3");
					throw new Exception($"Thread {Task.CurrentId} Some exceptio");
				});
				allTasks = Task.WhenAll(t1, t2, t3);
				allTasks.Wait();
			}
			catch (Exception ex)
			{
				Console.ForegroundColor = ConsoleColor.Red;
				foreach (var tex in allTasks.Exception.InnerExceptions)
				{
					Console.WriteLine(tex.Message);
				}
				Console.ForegroundColor = ConsoleColor.White;
			}
			finally {
				var t = Task.Run(() => {
					Console.WriteLine("в блоке finally");
				});
				t.Wait();
			}
		}

		private async void ArreyFactorialAsync() {
			Console.WriteLine($"Factorial raning");
			Task t1 = Task.Run(() => Factorial(4));
			Task t2 = Task.Run(() => Factorial(3));
			Task t3 = Task.Run(() => Factorial(5));

			await Task.WhenAll(new[] { t1, t2, t3});
		}

		private async void RunTaskFactorialAsync()
		{
			var x = await Factorial3Async(8);
			Console.WriteLine($"Факториал равен {x}");
		}

		private async Task<int> Factorial3Async(int n)
		{
			return await Task.Run(() => Factorial2(n));
		}


		private async void Factorial2Async(int n)
		{
			var x = await Task.Run(() => Factorial2(n));
			
			Console.WriteLine($"Факториал равен {x}");
		}

		private async void FactorialAsync(int n) {

			Console.WriteLine("Начало метода FactorialAsync");
			await Task.Run(() => Factorial(n));
			Console.WriteLine("Конец метода FactorialAsync");
		}

		private void Factorial(int n)
		{
			int result = 1;
			for (int i = 1; i <= n; i++)
			{
				result *= i;
			}		
			Thread.Sleep(8000);
			Console.WriteLine($"Факториал числа {n} равен {result}");
		}

		private int Factorial2(int n)
		{
			int result = 1;
			for (int i = 1; i <= n; i++)
			{
				result *= i;
			}
			Console.WriteLine($"Factorial2 Число {n}");
			Thread.Sleep(10000);
			return result;
		}

		private void FactorialWithCancell(int n, CancellationToken token) {

			int result = 1;
			for (int i = 1; i <= n; i++) {
				if (token.IsCancellationRequested) {
					Console.WriteLine("Операция прервана токеном");
					return;
				}
				result *= i;
				Console.WriteLine($"Факториал числа {i} равен {result}");
				Thread.Sleep(1000);
			}


		}

	}
}
