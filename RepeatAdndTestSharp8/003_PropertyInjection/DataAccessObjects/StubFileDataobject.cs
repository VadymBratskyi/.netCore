using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003_PropertyInjection.DataAccessObjects
{
    class StubFileDataObject : IDataAccessObject
    {
        public List<string> GetFiles()
        {
            return new List<string>
            {
                "file1.txt",
                "file2.log",
                "file3.exe",
                "main.log"
            };
        }
    }
}
