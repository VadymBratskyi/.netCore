using _005_LocalFactoryMethod.DataAccessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _005_LocalFactoryMethod
{
    class FileManager
    {
        public FileManager() { 
        
        }

        protected virtual IDataAccessObject CreateDataAccessObject() {
            return new FileDataObject();
        }

        public bool FindlogFile(string fileName)
        {
            var dataAccessObject = CreateDataAccessObject();

            List<string> files = dataAccessObject.GetFiles();

            return files.Any(f => f == fileName);
        }

    }
}
