using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class CartService
    {
        public static void AddToCart(int src, string uname)
        {
            DataAccessFactory.CartDataAcess().AddToCart(src, uname);
        }

        public static void ClearCart(string uname)
        {
            DataAccessFactory.CartDataAcess().ClearCart(uname);
        }

        public static void DeleteCart(int src)
        {
            DataAccessFactory.CartDataAcess().DeleteCart(src);
        }

        public static List<Cart> GetCartByUsername(string uname)
        {
            var da = DataAccessFactory.CartDataAcess();
            var data = da.GetCartByUsername(uname);
            return data;
        }

        public static void MinusCart(int src)
        {
            DataAccessFactory.CartDataAcess().MinusCart(src);
        }

        public static void PlusCart(int src)
        {
            DataAccessFactory.CartDataAcess().PlusCart(src);
        }
    }
}
