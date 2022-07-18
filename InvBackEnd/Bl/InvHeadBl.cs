using InvBackEnd.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvBackEnd.Bl
{
    public class InvheadBl : IFunctionCrud<InvheadTb>
    {
        public InvheadTb OInvhead;

        private InvoceDbContext _DbContext;

        public InvheadBl()
        {
            OInvhead = new InvheadTb();
            _DbContext = new InvoceDbContext();
        }

        public int AutoNumber()
        {
             
            return GenralFuctiono.AutoNo(_DbContext.InvheadTbs.Select(a => a.Id).ToList());

        }

        public bool Delete(int id)
        {
            OInvhead = _DbContext.InvheadTbs.FirstOrDefault(a => a.Id == id);
            if (OInvhead!=null) 
            {
                _DbContext.InvheadTbs.Remove(OInvhead);
                _DbContext.SaveChanges();
                return true; 
            }
            else return false;
        }

        public List<InvheadTb> GetData()
        {
        return    _DbContext.InvheadTbs.ToList();
        }

        public object GetDataById(int id)
        {
            return _DbContext.InvheadTbs.FirstOrDefault(a=>a.Id==id);
        }

        public bool Insert(InvheadTb Entitty)
        {
            _DbContext.InvheadTbs.Add(Entitty);
            _DbContext.SaveChanges();
            return true;
        }

        public bool Update(InvheadTb Entitty)
        {
            _DbContext.InvheadTbs.Remove(Entitty);
            _DbContext.InvheadTbs.Add(Entitty);
            _DbContext.SaveChanges();   
            return true;    
        }
    }
}
