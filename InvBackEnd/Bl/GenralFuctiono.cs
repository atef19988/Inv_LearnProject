using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvBackEnd.Bl
{
    public class GenralFuctiono
    {

        public static int AutoNo(List<int> Table)
        {
            if (Table.FirstOrDefault() != null)
            {
                if (Table.Count() != 0)
                {
                    return Table.Max() + 1;

                }
                else
                    return 1;
            }
            else
                return 1;
        }

    }
}
