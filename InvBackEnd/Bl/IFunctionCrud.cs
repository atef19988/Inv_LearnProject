using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvBackEnd.Bl
{
    public interface IFunctionCrud<T>
    {
        bool Insert(T Entitty);

        bool Update(T Entitty);
        bool Delete(int id);

        List<T> GetData();
        object GetDataById(int id);
        int AutoNumber();
    }
}
