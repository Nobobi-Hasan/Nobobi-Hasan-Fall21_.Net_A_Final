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
            var orders = (from o in db.Orders
                          where o.CustomerName == e.Username
                          select o).ToList();

       
            foreach (var o in orders)
            {
                var details = (from od in db.OrderDetails
                               where od.OrderId == o.Id
                               select od).ToList();

                foreach (var d in details)
                {
                    db.OrderDetails.Remove(d);
                    db.SaveChanges();
                }
                db.Orders.Remove(o);
                db.SaveChanges();
            }



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
