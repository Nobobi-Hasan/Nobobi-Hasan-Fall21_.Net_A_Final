using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class CustomerRepo : IRepo<Customer, string, string>
    {
        KetabKhanaFEntities db;
        public CustomerRepo(KetabKhanaFEntities db)
        {
            this.db = db;
        }

        public void Add(Customer e)
        {
            db.Customers.Add(e);
            db.SaveChanges();
        }

        

        public void Delete(Customer e)
        {
            var n = db.Customers.FirstOrDefault(en => en.Username == e.Username);
            db.Customers.Remove(n);
            db.SaveChanges();
        }

        public void Edit(Customer e)
        {
            var n = db.Customers.FirstOrDefault(en => en.Username == e.Username);
            db.Entry(n).CurrentValues.SetValues(e);
            db.SaveChanges();
        }

        public List<Customer> GetAll()
        {
            return db.Customers.ToList();
        }

        

        public Customer GetOne(string id)
        {
            return db.Customers.FirstOrDefault(e => e.Username == id);
        }





        //extra ############################################

        public void Add(Customer e, string src)
        {
            throw new NotImplementedException();
        }

        public List<Customer> GetByUsername(string src)
        {
            throw new NotImplementedException();
        }



    }
}
