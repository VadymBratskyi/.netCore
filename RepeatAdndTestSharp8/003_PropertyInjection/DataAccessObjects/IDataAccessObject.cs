using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003_PropertyInjection.DataAccessObjects
{
    public interface IDataAccessObject
    {
        List<string> GetFiles();
    }
}
