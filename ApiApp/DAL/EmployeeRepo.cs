using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class EmployeeRepo : IRepo<Employee, string, string>
    {
        KetabKhanaFEntities db;
        public EmployeeRepo(KetabKhanaFEntities db)
        {
            this.db = db;
        }



        public void Add(Employee e)
        {
            db.Employees.Add(e);
            db.SaveChanges();
        }

        

        public void Delete(Employee e)
        {
            var n = db.Employees.FirstOrDefault(en => en.Username == e.Username);
            db.Employees.Remove(n);
            db.SaveChanges();
        }

        public void Edit(Employee e)
        {
            var n = db.Employees.FirstOrDefault(en => en.Username == e.Username);
            db.Entry(n).CurrentValues.SetValues(e);
            db.SaveChanges();
        }

        public List<Employee> GetAll()
        {
            return db.Employees.ToList();
        }

        

        public Employee GetOne(string id)
        {
            return db.Employees.FirstOrDefault(e => e.Username == id);
        }

        //extra ############################################

        public void Add(Employee e, string src)
        {
            throw new NotImplementedException();
        }

        public List<Employee> GetByUsername(string src)
        {
            throw new NotImplementedException();
        }


    }
}
