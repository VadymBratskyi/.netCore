using System;
using System.IO;
using System.Collections.Generic;
using System.Text;

namespace RepeatAdndTestSharp8.FilesDirectories
{
    class Directories
    {
        private string DirectoryPath;

        public Directories(string directPath) {
            DirectoryPath = directPath;
        }


        public void DirectoryMoveTo(string oldDirectPath, string newDirectPath) {

            var dirPath = DirectoryPath + oldDirectPath;
            var newPath = DirectoryPath + newDirectPath;

            DirectoryInfo dir = new DirectoryInfo(dirPath);
            if (dir.Exists && Directory.Exists(newPath) == false) {
                dir.MoveTo(newPath);
            }
        }

        public void DeleteDirective(string directPath) {
            var dirPath = DirectoryPath + directPath;

            try {
                DirectoryInfo dir = new DirectoryInfo(dirPath);
                dir.Delete(true);
            }
            catch (Exception ex) {
                Console.WriteLine(ex.Message);
            }
        }

        public void GetDirectoryInfo(string directInfo) {

            var dirPath = DirectoryPath + directInfo;

            DirectoryInfo drInf = new DirectoryInfo(dirPath);
            Console.WriteLine("Name: " + drInf.Name);
            Console.WriteLine("FullName: "+drInf.FullName);
            Console.WriteLine("CreationTime: "+drInf.CreationTime);
            Console.WriteLine("Parent: "+drInf.Parent);
            Console.WriteLine("Root: "+drInf.Root);

        }

        public void CreateDirectory(string name) {
            var path = DirectoryPath + name;            
            DirectoryInfo direct = new DirectoryInfo(path);
            if (!direct.Exists) {
                direct.Create();
            }                
        }
        public void CreateDirectory(string name, string subDirectoryName)
        {
            var path = DirectoryPath + name;
            DirectoryInfo direct = new DirectoryInfo(path);
            if (!direct.Exists)
            {
                direct.Create();
            }
            direct.CreateSubdirectory(subDirectoryName);
        }

        public void GetDirectories() {

            Console.WriteLine("Directories");

            foreach (var dir in Directory.GetDirectories(DirectoryPath)) {
                Console.WriteLine(dir);
            }

        }

        public void GetFiles(string filePath)
        {
            var path = DirectoryPath + filePath;

            Console.WriteLine("Files");

            foreach (var fl in Directory.GetFiles(path))
            {
                Console.WriteLine(fl);
            }

        }
    }
}
