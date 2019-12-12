using System;
using System.Collections.Generic;
using System.Text;

namespace RepeatAdndTestSharp8.WorkDelegate
{
	public class WorkDelegates
	{
		public delegate void Message();
		public delegate int Operation(int x, int y);
		public delegate void MultipleDelage();
		public delegate T AnyDelegate<T,K>(K val);
		public delegate bool IsEqual(int x);
		
		public int SumLymda(int[] numbers, IsEqual func)
		{
			int result = 0;
			foreach (int i in numbers)
			{
				if (func(i))
					result += i;
			}
			return result;
		}

		public void RunAnyDeleagate() {

			AnyDelegate<decimal, int> op = Square;

			Console.WriteLine(op(5));

		}

		private decimal Square(int n)
		{
			return n * n;
		}

		public void RunMultipleDelegate(params MultipleDelage[] delegates) {

			MultipleDelage myDel = Hello;

			foreach (MultipleDelage del in delegates) {
				myDel += del;
			}

			myDel();

		}

		private void Hello()
		{
			Console.WriteLine("Hello");
		}
		

		public void RunOperation(Operation inputOPeration = null) {

			Operation op = inputOPeration;
			int result = 0;

			if (op == null)
			{

				op = Add;

				result = op(4, 6);
				Console.WriteLine(result);

				op = Multiply;
				result = op(4, 6);
				Console.WriteLine(result);

			}
			else {
				result = op(1,2);
				Console.WriteLine(result);

			}


		}

		private int Add(int x, int y)
		{
			return x + y;
		}

		private int Multiply(int x, int y)
		{
			return x * y;
		}

		public void InitDelegateTimeOfDay() {

			Message ms;
			if (DateTime.Now.Hour < 12)
			{
				ms = GoodMorning;
			}
			else {
				ms = GoodEvening;
			}

			ms();
		}

		private void GoodMorning() {
			Console.WriteLine("Good Morning!");
		}

		private void GoodEvening()
		{
			Console.WriteLine("Good Evening!");
		}

	}
}
