using InvBackEnd.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvBackEnd.Bl
{
    public class ProductBl : IFunctionCrud<ProductTb>
    {
        public ProductTb OProduct;

        private InvoceDbContext _DbContext;

        public ProductBl()
        {
            OProduct = new ProductTb();
            _DbContext = new InvoceDbContext();
        }
        public int AutoNumber()
        {

            return GenralFuctiono.AutoNo(_DbContext.ProductTbs.Select(a => a.Id).ToList());

        }
        public bool Delete(int id)
        {
            OProduct = _DbContext.ProductTbs.FirstOrDefault(a => a.Id == id);
            if (OProduct!=null) 
            {
                _DbContext.ProductTbs.Remove(OProduct);
                _DbContext.SaveChanges();
                return true; 
            }
            else return false;
        }

        public List<ProductTb> GetData()
        {
        return    _DbContext.ProductTbs.ToList();
        }

        public object GetDataById(int id)
        {
            return _DbContext.ProductTbs.FirstOrDefault(a=>a.Id==id);
        }

        public bool Insert(ProductTb Entitty)
        {
            Entitty.Id= AutoNumber();
            _DbContext.ProductTbs.Add(Entitty);
            _DbContext.SaveChanges();
            return true;
        }

        public bool Update(ProductTb Entitty)
        {
            _DbContext.ProductTbs.Remove(   _DbContext.ProductTbs.FirstOrDefault(a => a.Id == Entitty.Id));
            _DbContext.ProductTbs.Add(Entitty);
            _DbContext.SaveChanges();   
            return true;    
        }
    }
}
