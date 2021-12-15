using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    class OrderDetailRepo : IRepo<OrderDetail, string>
    {
        KetabKhanaFEntities db;
        public OrderDetailRepo(KetabKhanaFEntities db)
        {
            this.db = db;
        }



        public List<OrderDetail> GetAll()
        {
            return db.OrderDetails.ToList();
        }

        public List<OrderDetail> GetByShopName(string src)
        {
            var entity = (from e in db.OrderDetails
                          where e.ShopName == src
                          select e).ToList();
            return entity;
        }




        public List<OrderDetail> GetByCustomerName(string src)
        {
            throw new NotImplementedException();
        }


        //Extra ###############################################################

        public void Add(OrderDetail e)
        {
            throw new NotImplementedException();
        }

        
    }
}
