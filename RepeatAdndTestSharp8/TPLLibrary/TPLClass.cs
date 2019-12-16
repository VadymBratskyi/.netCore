using System;
using System.Threading;
using System.Threading.Tasks;

namespace TPLLibrary
{
	public partial class TPLClass
	{
		public void RunDiferentTasks() {

			Console.WriteLine("Task Library");
			//1
			Task task1 = new Task(() => Console.WriteLine("Hello World"));
			task1.Start();
			//2
			Task task2 = Task.Factory.StartNew(() => Console.WriteLine("Hello World"));
			//3
			Task task3 = Task.Run(() => Console.WriteLine("Hello World"));
			
			Console.WriteLine("Завершение метода RunDiferentTasks");

		}

		public void GetTaskWithMethod() {

			Task task4 = new Task(Display);
			task4.Start();
			task4.Wait();
		}

		public void RunOuterInnerTasks() {

			var outer = Task.Factory.StartNew(() => {

				Console.WriteLine("Ouuter tasks");
				var inner = Task.Factory.StartNew(() => {

					Console.WriteLine("Inner start");
					Thread.Sleep(2000);
					Console.WriteLine("Inner finish");
				
				});
				//}, TaskCreationOptions.AttachedToParent);

		});

			outer.Wait();
			Console.WriteLine("End of RunOuterInnerTasks");

		}

	
		private void Display() {
			Console.WriteLine("Начало работы метода Display");

			Console.WriteLine("Завершение работы метода Display");
		}

	}
}
