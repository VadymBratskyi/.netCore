using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Text;

namespace RepeatAdndTestSharp8.FilesDirectories
{
    class Zip
    {
        private string drivePath;

        public Zip(string drivePath)
        {
            this.drivePath = drivePath;
        }

        public void RunCompressDEcompres() {

            string sourceFile = drivePath + "myDir\\test\\book.pdf"; // исходный файл
            string compressedFile = drivePath + "myDir\\test\\book.gz"; // сжатый файл
            string targetFile = drivePath + "myDir\\test\\book_new.pdf"; // восстановленный файл

            // создание сжатого файла
            Compress(sourceFile, compressedFile);
            // чтение из сжатого файла
            Decompress(compressedFile, targetFile);

        }

        private static void Compress(string sourceFile, string compressedFile)
        {
            // поток для чтения исходного файла
            using (FileStream sourceStream = new FileStream(sourceFile, FileMode.OpenOrCreate))
            {
                // поток для записи сжатого файла
                using (FileStream targetStream = File.Create(compressedFile))
                {
                    // поток архивации
                    using (GZipStream compressionStream = new GZipStream(targetStream, CompressionMode.Compress))
                    {
                        sourceStream.CopyTo(compressionStream); // копируем байты из одного потока в другой
                        Console.WriteLine("Сжатие файла {0} завершено. Исходный размер: {1}  сжатый размер: {2}.",
                            sourceFile, sourceStream.Length.ToString(), targetStream.Length.ToString());
                    }
                }
            }
        }

        private static void Decompress(string compressedFile, string targetFile)
        {
            // поток для чтения из сжатого файла
            using (FileStream sourceStream = new FileStream(compressedFile, FileMode.OpenOrCreate))
            {
                // поток для записи восстановленного файла
                using (FileStream targetStream = File.Create(targetFile))
                {
                    // поток разархивации
                    using (GZipStream decompressionStream = new GZipStream(sourceStream, CompressionMode.Decompress))
                    {
                        decompressionStream.CopyTo(targetStream);
                        Console.WriteLine("Восстановлен файл: {0}", targetFile);
                    }
                }
            }
        }
    }

}
