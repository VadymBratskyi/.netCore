using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _007_FactoryInjection.DataAccessObjects
{
    public class DataAccessFactory
    {
        private static IDataAccessObject dataAccessObject;

        internal static IDataAccessObject Create() {

            if (dataAccessObject != null) {

                return dataAccessObject;

            }

            return new FileDataObject();

        }

        [Conditional("DEBUG")]//не попадет в сборку. будет игнорироваться но не при дебаге
        public static void SetDataAccessObject(IDataAccessObject customDataAccessObject)
        {
            dataAccessObject = customDataAccessObject;
        }

    }
}
