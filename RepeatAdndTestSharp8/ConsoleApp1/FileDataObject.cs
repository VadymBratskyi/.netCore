using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace _001_Problem
{
    class FileDataObject
    {

        public List<string> GetFiles() {

            string path = Directory.GetCurrentDirectory();

            List<string> list = new List<string>();
            DirectoryInfo directoryInfo = new DirectoryInfo(path);
            FileInfo[] files = directoryInfo.GetFiles();
           
            foreach (var file in files) {

                list.Add(file.Name);

            }

            return list;
            
        }

    }
}
