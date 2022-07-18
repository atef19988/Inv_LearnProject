using Bl.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bl.Bl
{
    public class CustomerControl : IFunction<Customer>
    {
        private invContext db;
        private Customer customers;

        public CustomerControl()
        {
           db = new invContext();
           customers = new Customer();
        }
    
        public List<Customer> GetData()
        {
            return db.Customers.ToList();
        }

        public object GetDataById(int id)
        {
            return db.Customers.Where(a => a.Id == id);
        }

        public bool Insert(Customer customer)
        {
            customer.Id=AutoNumper();
            db.Customers.Add(customer);            
            db.SaveChanges();
       
            return true;

        }

        public bool Update(Customer customer)
        {
            customers = db.Customers.FirstOrDefault(a => a.Id == customer.Id);
            if (customers != null)
            {
                db.Customers.Remove(customers);
                db.Customers.Add(customer);
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
            customers = db.Customers.FirstOrDefault(a => a.Id == id);
            if (customers!=null)
            {
                db.Customers.Remove(customers);
                db.SaveChanges();
                return true;
            }
           else
                return false;   
        }

        public int AutoNumper()
        {
            customers = db.Customers.FirstOrDefault();
            if (customers != null)
            {
                return db.Customers.Max(a => a.Id) + 1;
            }
            else
            {
                return 1;
            }
           
        }
    }
}
