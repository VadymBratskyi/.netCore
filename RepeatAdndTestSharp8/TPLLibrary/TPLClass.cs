using System;
using System.Threading;
using System.Threading.Tasks;

namespace TPLLibrary
{
	public partial class TPLClass
	{

		public void RunParaller() {

			Parallel.Invoke(Display,
			 () => {
				 Console.WriteLine($"Выполняется задача {Task.CurrentId}");
				 Thread.Sleep(3000);
			 },
			 () => Factorial(5));
		
		}

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

		public void RunArrayTasks() {

			Task[] tasks = new Task[3] {
				new Task(() => Console.WriteLine("First Task")),
				new Task(() => Console.WriteLine("Second Task")),
				new Task(() => Console.WriteLine("Third Task")),
			};

			foreach (Task t in tasks) {
				t.Start();			
			}

			//Task.WaitAll(tasks); //выполняца все задачи из массива, а уж потом завершит роботу метод main
			Task.WaitAny(tasks); //ждет, пока завершится хотя бы одна из массива задач.
		}

		public void RunTaskReturnAny()
		{
			Task<int> taskFactorial = new Task<int>(() => Factorial(5));
			taskFactorial.Start();

			Console.WriteLine($"Факториал числа 5 равен {taskFactorial.Result}");


			Task<Book> taskBook = new Task<Book>(() => {
				return new Book() { Title = "War and pees", Author = "Tolstoy" };
			});
			taskBook.Start();

			Book b = taskBook.Result;  // ожидаем получение результата
			Console.WriteLine($"Название книги: {b.Title}, автор: {b.Author}");

		}

		public void RunContinuatTask() {

			Task task1 = new Task(() => { Console.WriteLine($"Id Task {Task.CurrentId}"); });

			Task task2 = task1.ContinueWith(Display);

			task1.Start();
			task2.Wait();

			Task<int> taskSum = new Task<int>(() => Sum(4, 5));

			Task taskDisplay = taskSum.ContinueWith(sum => Display(sum.Result));

			taskSum.Start();
			taskDisplay.Wait();


			Console.WriteLine("Выполняется работа метода RunContinuatTask");
		}

		public void RunChineContinuatTask()
		{

			Task task1 = new Task(() => Console.WriteLine($"Id задачи: {Task.CurrentId}"));
			Task task2 = task1.ContinueWith((Task t) => Console.WriteLine($"Id задачи: {Task.CurrentId}"));
			Task task3 = task2.ContinueWith((Task t) => Console.WriteLine($"Id задачи: {Task.CurrentId}"));

			task1.Start();

			Console.WriteLine("Выполняется работа метода RunChineContinuatTask");
		}

		private int Sum(int a, int b) => a + b;

		static void Display(int sum)
		{
			Console.WriteLine($"Sum: {sum}");
		}

		private void Display(Task t)
		{
			Console.WriteLine($"Id задачи: {Task.CurrentId}");
			Console.WriteLine($"Id предыдущей задачи: {t.Id}");
			Thread.Sleep(3000);
		}

		private void Display() {
			Console.WriteLine("Начало работы метода Display");
			Console.WriteLine("Завершение работы метода Display");
		}

		private int Factorial(int x)
		{
			int result = 1;

			for (int i = 1; i <= x; i++)
			{
				result *= i;
			}

			return result;
		}

	}

	public class Book
	{
		public string Title { get; set; }
		public string Author { get; set; }
	}
}
