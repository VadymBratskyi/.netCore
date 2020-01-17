using RepeatAdndTestSharp8.Models.GC;
using System;
using TPLLibrary;
using System.Threading.Tasks;
using TPLLibrary.AsyncProgramm;

namespace RepeatAdndTestSharp8
{
    class Program
    {        
       
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

			AsyncPrograming asp = new AsyncPrograming();
			//asp.RunFactorialAsync();
			//asp.RunStreamAsync();
			//asp.RunArrayFactorialAsync();
			//asp.RunTaskWithExseption();
			asp.RunAsyncWithCancellation();


			//TPLClass tpl = new TPLClass();
			//tpl.RunParallerMethods();
			//tpl.RunParallerForForEachMethods();
			//tpl.WorkWithCancellationToken();
			//tpl.WorkWithCancellationTokenOutOfMethod();
			//tpl.RunDiferentTasks();
			//tpl.GetTaskWithMethod();
			//tpl.RunOuterInnerTasks();
			//tpl.RunArrayTasks();
			//tpl.RunTaskReturnAny();
			//tpl.RunContinuatTask(); 
			//tpl.RunChineContinuatTask();
			//tpl.RunParaller();
			//tpl.RunOuterInnerTasks();



			//WorkDelegates myDelegate = new WorkDelegates();
			//myDelegate.InitDelegateTimeOfDay();
			//myDelegate.RunOperation(TestOperation.Add2);
			//myDelegate.RunMultipleDelegate(TestOperation.HowAreYou, TestOperation.WhatAreYouDoing, () => { Console.WriteLine("FRom Anonimus"); });
			//myDelegate.RunAnyDeleagate();
			//int[] integers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
			//int result1 = myDelegate.SumLymda(integers, (x => x > 5));
			//Console.WriteLine(result1); // 30


			//TestString str = new TestString();
			//str.GetRegex();
			//str.GetStringBuilder();

			//SerializableDerializable serialize = new SerializableDerializable();
			//serialize.GetNewtonsoftSerialization(); 
			//serialize.GetArrNewtonsoftSerialization();
			//serialize.GetArrJSONSerialization(); 
			//serialize.GetJSONSerialization();
			//serialize.GetArrXMLSerialization();
			//serialize.GetXMLSerialization();
			//serialize.GetArrSOAPSerialization();
			//serialize.GetSOAPSerialization();
			//serialize.GetArrBinarySerialization();
			//serialize.GetBinarySerialization();

			//Zip zip = new Zip("C:\\");
			//zip.RunCompressDEcompres();

			//Files files = new Files("C:\\");
			//files.GetFileInfo("myDir\\test\\fl3.txt");
			//files.CreateFile("myDir\\test\\fl5.txt");
			//files.DeleteFile("myDir\\test\\fl5.txt");
			//files.MoveToFile("myDir\\test\\fl5.txt", "myDir\\vados\\fl5.txt");
			//files.CopyToFile("myDir\\test\\fl3.txt", "myDir\\vados\\fl3.txt");
			//files.RunWriteReadFileStream("myDir\\test\\fl3.txt"); 
			//files.ReplaceFileStreamValue("myDir\\test\\fl3.txt"); 
			//files.GetStreamWriter("myDir\\test\\fl3.txt");
			//files.GetStreamReader("myDir\\test\\fl3.txt");

			//Console.WriteLine();
			//Directories dir = new Directories("C:\\");
			//dir.CreateDirectory("myDir", "vados\\test\\vv");
			//dir.GetDirectoryInfo("myDir\\vados\\test\\vv");
			//dir.DirectoryMoveTo("myDir\\vados\\test", "myDir\\test");
			//dir.DeleteDirective("myDir\\vados\\test\\vv");            
			//Console.WriteLine();
			//dir.GetDirectories();
			//Console.WriteLine();
			//dir.GetFiles("myDir\\test\\");
			//DiscsInfo discs = new DiscsInfo();
			//discs.GetDriveInfo();


			//OfferNetDelegates netDel = new OfferNetDelegates();
			//netDel.RunAction();
			//netDel.RunPredicate();
			//netDel.RunFunction();

			//TestDelegate deleg = new TestDelegate();
			//deleg.RunBankDelegate(); 
			//deleg.RunDelegateAsParameter(); 
			//deleg.RunMultipleMethod();
			//deleg.RunOperatorDelegate();
			//deleg.RunSomeMethod();
			//deleg.RunTimeDelegte();

			//TestGurbeg();
			//Console.ReadLine();

			//Study st = new Study();
			//st.Eat();
			//st.Move();


			//Person p1 = new Person { name = "Bill", age = 34 };
			//Person p2 = new Person { name = "Tom", age = 23 };
			//Person p3 = new Person { name = "Alice", age = 21 };

			//Person[] people = new Person[] { p1, p2, p3 };

			//Array.Sort(people);

			//foreach (Person p in people)
			//{
			//    Console.WriteLine("{0} - {1}", p.name, p.age);
			//}

			//Person p1 = new Person() { name = "vados", age = 26, work = new Company() { Name = "Tera"} };
			//Person p2 = (Person)p1.Clone();

			//Console.WriteLine($"p1 {p1.name} {p1.work.Name}");
			//p2.name = "lena";
			//p2.work.Name = "Goog";
			//Console.WriteLine($"p2 {p2.name} {p2.work.Name}");
			//Console.WriteLine($"p1 {p1.name} {p1.work.Name}");


			//try
			//{
			//    TestClass.Method1();
			//}
			//catch (DivideByZeroException ex)
			//{
			//    Console.WriteLine($"Catch в Main : {ex.Message}");
			//}
			//finally
			//{
			//    Console.WriteLine("Блок finally в Main");
			//}
			//Console.WriteLine("Конец метода Main");



			//Counter count = new Counter() { Seconds = 25 };

			//int c = (int)count;
			//Console.WriteLine(c);

			//Counter count2 = 50;
			//Console.WriteLine(count2.Seconds);

			//Timer timer = count;
			//Console.WriteLine($"{timer.Hours}:{timer.Minutes}:{timer.Seconds}"); // 0:1:55

			//Counter counter2 = (Counter)timer;
			//Console.WriteLine(counter2.Seconds);  //115

			//Employee employee = new Employee("Tom", "Microsoft");
			//People people = employee;   // преобразование от Employee к Person

			//employee.Display();

			//Console.WriteLine(((Employee)people).Company);

			//var arr = new[] { "1", "2", "3" };
			//foreach (var ar in arr) {
			//    Console.Write(ar);
			//}
			//Console.WriteLine();

			//ChangeArray(arr);

			//Console.WriteLine();

			//foreach (var ar in arr)
			//{
			//    Console.Write(ar);
			//}


			//Client user1 = new Client();
			//user1[0] = new Phone() { Number = 123 };
			//user1[1] = new Phone() { Number = 456 };
			//user1[2] = new Phone() { Number = 789 };
			//Client user2 = new Client();
			//user2[0] = new Phone() { Number = 147 };
			//user2[1] = new Phone() { Number = 258 };
			//Client user3 = new Client();
			//Client user4 = new Client();
			//Client user5 = new Client();

			//Client.DisplayCounter(); // 5

			//user1.DisplayPhones();
			//user2.DisplayPhones();

			//Person p = new Person { name = "Tom", age = 23 };
			//ChangePerson(p);

			//Console.WriteLine(p.name); // Bill
			//Console.WriteLine(p.age); // 45

			//User tom = new User("ttt", 123);
			//tom.DisplayInfo();

			//var tuple = GetNamedValues(new int[] { 1, 2, 3, 4, 5, 6, 7 });
			//Console.WriteLine(tuple.count);
			//Console.WriteLine(tuple.sum);

			Console.ReadLine();
		}

        private static void TestGurbeg()
        {
            //Gurbeg p = null;
            //try
            //{
            //    p = new Gurbeg();
            //}
            //finally {
            //    if (p != null) {
            //        p.Dispose();
            //    }
            //}
            //=====
            using (Gurbeg p = new Gurbeg())
            {
            }
        }

    }
}
