using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bl.Bl
{
    public interface IFunction<T>
    {
        bool Insert(T Table);
        bool Update(T Table);
        bool Delete(int id);
        List<T> GetData();
        object GetDataById(int id);
        int AutoNumper();

    }
}
