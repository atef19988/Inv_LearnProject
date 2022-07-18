using Bl.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bl.Bl
{
    public class ProcductControl : IFunction<Procduct>
    {
        private invContext db;
        private Procduct Procducts;

        public ProcductControl()
        {
           db = new invContext();
           Procducts = new Procduct();
        }
    
        public List<Procduct> GetData()
        {
            return db.Procducts.ToList();
        }

        public object GetDataById(int id)
        {
            return db.Procducts.Where(a => a.Id == id);
        }

        public bool Insert(Procduct customer)
        {
            customer.Id=AutoNumper();
            db.Procducts.Add(customer);            
            db.SaveChanges();
       
            return true;

        }

        public bool Update(Procduct customer)
        {
            Procducts = db.Procducts.FirstOrDefault(a => a.Id == customer.Id);
            if (Procducts != null)
            {
                db.Procducts.Remove(Procducts);
                db.Procducts.Add(customer);
                db.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool Delete(int id)
        {
            Procducts = db.Procducts.FirstOrDefault(a => a.Id == id);
            if (Procducts!=null)
            {
                db.Procducts.Remove(Procducts);
                db.SaveChanges();
                return true;
            }
           else
                return false;   
        }

        public int AutoNumper()
        {
            Procducts = db.Procducts.FirstOrDefault();
            if (Procducts != null)
            {
                return db.Procducts.Max(a => a.Id) + 1;
            }
            else
            {
                return 1;
            }
           
        }
    }
}
