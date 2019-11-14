using _007_FactoryInjection.DataAccessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
//тип который доступный только в текущей сборке, можно розрешить вручную для конкретного другого проекта
//[assembly: InternalsVisibleTo("FileManagerLibrary.Test")]

namespace _007_FactoryInjection
{
    public class FileManager
    {
        IDataAccessObject dataAccessObject;

        public FileManager() {
            dataAccessObject = DataAccessFactory.Create();
        }

        public bool FindlogFile(string fileName)
        {
            List<string> files = dataAccessObject.GetFiles();

            return files.Any(f => f == fileName);
        }
    }
}
