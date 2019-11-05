using _002_ConstructorInjection.DataAccessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002_ConstructorInjection
{
    class FileManager
    {
        private IDataAccessObject _dataAccessObject;

        public FileManager() {
            _dataAccessObject = new FileDataObject();
        }

        public FileManager(IDataAccessObject dataAccessObject) {
            _dataAccessObject = dataAccessObject;
        }

        public bool FindLogFile(string fileName) {

            List<string> files = _dataAccessObject.GetFiles();

            return files.Any(f => f == fileName);

        }

    }
}
