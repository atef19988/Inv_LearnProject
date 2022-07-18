using InvBackEnd.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvBackEnd.Bl
{
    public class InvDescrptionBl : IFunctionCrud<InvDescrptionTb>
    {
        public InvDescrptionTb OInvDescrption;

        private InvoceDbContext _DbContext;

        public InvDescrptionBl()
        {
            OInvDescrption = new InvDescrptionTb();
            _DbContext = new InvoceDbContext();
        }

        public int AutoNumber()
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            OInvDescrption = _DbContext.InvDescrptionTbs.FirstOrDefault(a => a.Id == id);
            if (OInvDescrption!=null) 
            {
                _DbContext.InvDescrptionTbs.Remove(OInvDescrption);
                _DbContext.SaveChanges();
                return true; 
            }
            else return false;
        }

        public List<InvDescrptionTb> GetData()
        {
        return    _DbContext.InvDescrptionTbs.ToList();
        }

        public object GetDataById(int id)
        {
            return _DbContext.InvDescrptionTbs.FirstOrDefault(a=>a.Id==id);
        }

        public bool Insert(InvDescrptionTb Entitty)
        {
            _DbContext.InvDescrptionTbs.Add(Entitty);
            _DbContext.SaveChanges();
            return true;
        }

        public bool Update(InvDescrptionTb Entitty)
        {
            _DbContext.InvDescrptionTbs.Remove(Entitty);
            _DbContext.InvDescrptionTbs.Add(Entitty);
            _DbContext.SaveChanges();   
            return true;    
        }
    }
}
