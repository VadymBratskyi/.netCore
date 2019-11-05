using _004_InterfaceInjection.DataAccessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceInjection
{
    class FileManager
    {
        public bool FindlogFile(string fileName, IDataAccessObject dataAccessObject) {

            if (dataAccessObject == null)
            {
                throw new MemberAccessException("DataAccessObject has not been initialized.");
            }

            List<string> files = dataAccessObject.GetFiles();

            return files.Any(f => f == fileName);
        }
    }
}
