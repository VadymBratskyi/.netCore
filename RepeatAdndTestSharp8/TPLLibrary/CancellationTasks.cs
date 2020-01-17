using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TPLLibrary
{
	public partial class TPLClass
	{
		public void WorkWithCancellationToken() {

			CancellationTokenSource cancellationToken = new CancellationTokenSource();
			CancellationToken token = cancellationToken.Token;
			int number = 6;

			Task task = new Task(() => {

				int result = 1;
				
				for (int i =1; i <= number; i++) {
					if (token.IsCancellationRequested) {
						Console.WriteLine("Task stoped");
						return;
					}
					result *= i;
					Console.WriteLine($"Факториал числа {number} равен {result}");
					Thread.Sleep(5000);
				}
			});
			task.Start();

			Console.WriteLine("Введите Y для отмены операции или другой символ для ее продолжения:");
			string s = Console.ReadLine();
			if (s == "Y"){
				cancellationToken.Cancel();
			}
				
		}

		public void WorkWithCancellationTokenOutOfMethod()
		{
			CancellationTokenSource cancelTokenSource = new CancellationTokenSource();
			CancellationToken token = cancelTokenSource.Token;

			Task task1 = new Task(() => Factorial(5, token));
			task1.Start();

			Console.WriteLine("Введите Y для отмены операции или любой другой символ для ее продолжения:");
			string s = Console.ReadLine();
			if (s == "Y") {
				cancelTokenSource.Cancel();
			}			

		}

		private void Factorial(int x, CancellationToken token)
		{
			int result = 1;
			for (int i = 1; i <= x; i++)
			{
				if (token.IsCancellationRequested)
				{
					Console.WriteLine("Операция прервана токеном");
					return;
				}

				result *= i;
				Console.WriteLine($"Факториал числа {x} равен {result}");
				Thread.Sleep(5000);
			}
		}
	}
}
