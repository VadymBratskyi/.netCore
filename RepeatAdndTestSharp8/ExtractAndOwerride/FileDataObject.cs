using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _006_ExtractAndOwerride
{
    class FileDataObject
    {
        public List<string> GetFiles()
        {
            string path = Directory.GetCurrentDirectory();

            List<string> list = new List<string>();

            DirectoryInfo directoryInfo = new DirectoryInfo(path);
            
            FileInfo[] fileInfos = directoryInfo.GetFiles();

            return fileInfos.Select(f => f.Name).ToList();

        }
    }
}
