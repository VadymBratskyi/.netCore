using System;
using System.IO;
using System.Collections.Generic;
using System.Text;

namespace RepeatAdndTestSharp8.FilesDirectories
{
    public class Files
    {
        private string drivePath;

        public Files(string drivePath) {
            this.drivePath = drivePath;
        }

        public void GetBinaryWriterReader(string flPath)
        {
            var path = drivePath + flPath;

            State[] states = new State[2];
            states[0] = new State("Германия", "Берлин", 357168, 80.8);
            states[1] = new State("Франция", "Париж", 640679, 64.7);


            using (BinaryWriter writer = new BinaryWriter(File.Open(path, FileMode.OpenOrCreate)))
            {
                // записываем в файл значение каждого поля структуры
                foreach (State s in states)
                {
                    writer.Write(s.name);
                    writer.Write(s.capital);
                    writer.Write(s.area);
                    writer.Write(s.people);
                }
            }
            // создаем объект BinaryReader
            using (BinaryReader reader = new BinaryReader(File.Open(path, FileMode.Open)))
            {
                // пока не достигнут конец файла
                // считываем каждое значение из файла
                while (reader.PeekChar() > -1)
                {
                    string name = reader.ReadString();
                    string capital = reader.ReadString();
                    int area = reader.ReadInt32();
                    double population = reader.ReadDouble();

                    Console.WriteLine("Страна: {0}  столица: {1}  площадь {2} кв. км   численность населения: {3} млн. чел.",
                        name, capital, area, population);
                }
            }

        }

        public void GetStreamWriter(string flPath)
        {
            var path = drivePath + flPath;

            string txt = "hello";

            using (StreamReader strR = new StreamReader(path, Encoding.Default))
            {
                txt = strR.ReadToEnd();
            }

            using (StreamWriter strW = new StreamWriter(path, false, Encoding.Default))
            {
                strW.WriteLine(txt);
            }

            using (StreamWriter strW = new StreamWriter(path, true, Encoding.Default))
            {
                strW.WriteLine("Дозапись");
                strW.Write(4.5);
            }

        }

        public void GetStreamReader(string flPath)
        {
            var path = drivePath + flPath;

            Console.WriteLine("******считываем весь файл********");
            using (StreamReader strRead = new StreamReader(path))
            {
                Console.WriteLine(strRead.ReadToEnd());
            }
            Console.WriteLine();
            Console.WriteLine("******считываем построчно********");
            using (StreamReader strR = new StreamReader(path, Encoding.Default))
            {
                string line;
                while ((line = strR.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }
            Console.WriteLine();
            Console.WriteLine("******считываем блоками********");
            using (StreamReader strR = new StreamReader(path, Encoding.Default)) {

                char[] array = new char[4];
                strR.Read(array, 0, 4);
                Console.WriteLine(array);

            }

        }

        public void ReplaceFileStreamValue(string flPath)
        {

            var path = drivePath + flPath;

            using (FileStream str = new FileStream(path, FileMode.OpenOrCreate)) {

                byte[] input = new byte[str.Length];
                str.Read(input, 0, input.Length);

                var stringForm = Encoding.Default.GetString(input);
                Console.WriteLine(stringForm);


                // заменим в файле слово world на слово house
                string replaceText = "house";
                str.Seek(-5, SeekOrigin.End); // минус 5 символов с конца потока
                input = Encoding.Default.GetBytes(replaceText);
                str.Write(input, 0, input.Length);

                // считываем весь файл
                // возвращаем указатель в начало файла
                str.Seek(0, SeekOrigin.Begin);
                var output = new byte[str.Length];
                str.Read(output, 0, output.Length);
                // декодируем байты в строку
                var textFromFile = Encoding.Default.GetString(output);
                Console.WriteLine("Текст из файла: {0}", textFromFile); 

            }
        }

        public void RunWriteReadFileStream(string flPath) {

            var path = drivePath + flPath;

            Console.WriteLine("Введите строку для записи в файл:");
            string text = Console.ReadLine();

            using (FileStream str = new FileStream(path, FileMode.OpenOrCreate)) {

                byte[] array = Encoding.Default.GetBytes(text);

                str.Write(array,0, array.Length);
                Console.WriteLine("Текст записан в файл");

            }

            using (FileStream str = File.OpenRead(path)) {

                byte[] array = new byte[str.Length];               

                str.Read(array, 0, array.Length);

                string textFormat = Encoding.Default.GetString(array);
                Console.WriteLine("all text: "+textFormat);

                // перемещаем указатель в конец файла, до конца файла- пять байт
                str.Seek(-5, SeekOrigin.End); // минус 5 символов с конца потока

                // считываем четыре символов с текущей позиции
                byte[] output = new byte[4];
                str.Read(output, 0, output.Length);
                // декодируем байты в строку
                string textFromFile = Encoding.Default.GetString(output);
                Console.WriteLine("Текст из файла Seek(-5): {0}", textFromFile); // worl

            }
            
        } 

        public void CopyToFile(string filePath, string copyPath)
        {
            var copyP = drivePath + copyPath;

            var fl = GetFile(filePath);

            if (fl.Exists)
            {
                fl.CopyTo(copyP, true);//перзаписівать или нет
                //File.Copy(filePath, copyP, true);
                Console.WriteLine("Copied {0}", fl.Name);
            }
        }

        public void MoveToFile(string filePath, string newPath)
        {
            var newP = drivePath + newPath;
            var fl = GetFile(filePath);

            if (fl.Exists)
            {
                fl.MoveTo(newP);
                //File.Move(filePath, newPath);
                Console.WriteLine("Moved {0}", fl.Name);
            }
        }

        public void DeleteFile(string filePath)
        {
            var fl = GetFile(filePath);

            if (fl.Exists)
            {
                fl.Delete();
                //File.Delete(filePath);
                Console.WriteLine("Deleted {0}", fl.Name);
            }
        }

        public void CreateFile(string filePath)
        {
            var fl = GetFile(filePath);

            if (!fl.Exists)
            {
                fl.Create();
                Console.WriteLine("Created {0}", fl.Name);
            }
        }

        public void GetFileInfo(string filePath)
        {
            var fl = GetFile(filePath);

            if (fl.Exists) {
                Console.WriteLine(fl.Name);
                Console.WriteLine(fl.CreationTime);
                Console.WriteLine(fl.Length);
            }
        }
        
        private FileInfo GetFile(string filePath)
        {
            var path = drivePath + filePath;

            return new FileInfo(path);

        }
    }
}
