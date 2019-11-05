using _006_ExtractAndOwerride;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _006_ExtractAndOwerride
{
    class FileManager
    {
        public virtual List<string> GetFiles() {

            return new FileDataObject().GetFiles();

        }

        public bool FindlogFile(string fileName)
        {
            List<string> files = GetFiles();

            return files.Any(f => f == fileName);
        }
    }
}
