using InvBackEnd.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace InvBackEnd.Bl
{
    public class CustomerBl : IFunctionCrud<CustomerTb>
    {
        public CustomerTb OCustomer;

        private InvoceDbContext _DbContext;

        public CustomerBl()
        {
            OCustomer = new CustomerTb();
            _DbContext = new InvoceDbContext();
        }

        public int AutoNumber()
        {

            return GenralFuctiono.AutoNo(_DbContext.CustomerTbs.Select(a=>a.Id).ToList());



        }

        public bool Delete(int id)
        {
            OCustomer = _DbContext.CustomerTbs.FirstOrDefault(a => a.Id == id);
            if (OCustomer!=null) 
            {
                _DbContext.CustomerTbs.Remove(OCustomer);
                _DbContext.SaveChanges();
                return true; 
            }
            else return false;
        }

        public List<CustomerTb> GetData()
        {
        return    _DbContext.CustomerTbs.ToList();
        }

        public object GetDataById(int id)
        {
            return _DbContext.CustomerTbs.FirstOrDefault(a=>a.Id==id);
        }

        public bool Insert(CustomerTb Entitty)
        {
            Entitty.Id= AutoNumber();
            _DbContext.CustomerTbs.Add(Entitty);
            _DbContext.SaveChanges();
            return true;
        }

        public bool Update(CustomerTb Entitty)
        {
            _DbContext.CustomerTbs.Remove(_DbContext.CustomerTbs.FirstOrDefault(a => a.Id == Entitty.Id));
            _DbContext.CustomerTbs.Add(Entitty);
            _DbContext.SaveChanges();   
            return true;    
        }
    }
}
