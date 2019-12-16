using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TPLLibrary
{
	partial class TPLClass
	{
		public void RunParallerMethods() {

			Parallel.Invoke(
			Display,
			() => {
				Console.WriteLine($"Running task {Task.CurrentId}");
				Thread.Sleep(300);
			},
			() => Factorial(5));
		
		}


		public void RunParallerForForEachMethods()
		{
			//Parallel.For(1, 10, FactorialLoop);
			ParallelLoopResult result = Parallel.ForEach<int>(new List<int> { 1, 2, 3, 4, 5, 8 }, FactorialLoop);
			if (!result.IsCompleted)
				Console.WriteLine($"Выполнение цикла завершено на итерации {result.LowestBreakIteration}");
		}

		public void DisplayParallel() {
			Console.WriteLine($"Running task {Task.CurrentId}");
			Thread.Sleep(3000);
		}

		public void FactorialLoop(int x, ParallelLoopState pls)
		{
			int result = 1;

			for (int i = 1; i <= x; i++) {
				result *= i;

				if (i == 5) {
					pls.Break();
				}
			}

			Console.WriteLine($"Running task {Task.CurrentId}");
			Thread.Sleep(3000);
			Console.WriteLine($"Result {result}");
		}

		public void Factorial(int x)
		{
			int result = 1;

			for (int i = 1; i <= x; i++)
			{
				result *= i;
			}

			Console.WriteLine($"Running task {Task.CurrentId}");
			Thread.Sleep(3000);
			Console.WriteLine($"Result {result}");
		}
	}
}
