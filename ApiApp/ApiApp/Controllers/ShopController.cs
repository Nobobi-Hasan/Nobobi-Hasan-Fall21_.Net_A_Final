using BEL;
using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace ApiApp.Controllers
{
    [EnableCors("*", "*", "*")]
    public class ShopController : ApiController
    {

        //Book #######################################################

        [Route("api/Shop/Book/GetAll")]
        [HttpGet]
        public List<BookModel> GetAllBooks()
        {
            return BookService.GetAll();
        }

        [Route("api/Shop/Book/Add")]
        [HttpPost]
        public void Add(BookModel b)
        {
            //string uname = User.Identity.Name;
            string uname = "shop1";
            b.ShopName = uname;
            BookService.Add(b);
        }

        [Route("api/Shop/Book/GetByUsername")]
        [HttpGet]
        public List<BookModel> GetByUsername()
        {
            //string sName = User.Identity.Name;
            string uname = "shop1";
            return BookService.GetByUsername(uname);
        }

        [Route("api/Shop/OneBook/{bId}")]
        [HttpGet]
        public BookModel OneBook(int bId)
        {

            return BookService.GetOne(bId);
        }


        [Route("api/Shop/Book/Edit")]
        [HttpPost]
        public void EditBook(BookModel b)
        {
            BookService.Edit(b);
        }

        [Route("api/Shop/Book/Delete")]
        [HttpPost]
        public void DeleteBook(BookModel b)
        {
            BookService.Delete(b);
        }


        //Order (Details) #######################################################

        [Route("api/Shop/Orders/GetByUsername")]
        [HttpGet]
        public List<OrderDetailModel> GetMyOrders()
        {
            //string sName = User.Identity.Name;
            string uname = "shop1";
            return OrderDetailService.GetByShopName(uname);
        }


        //Singels #######################################################

        [Route("api/Shop/MyTransactions")]
        [HttpGet]
        public List<TransactionModel> GetMyTransactions()
        {
            string uname = "shop1";
            return TransactionService.GetByShopName(uname);
        }

        [Route("api/Shop/AddSupport")]
        [HttpGet]
        public void AddSupport(SupportModel s)
        {
            SupportService.Add(s);
        }


        //Profile ###########################################

        [Route("api/Shop/Profile")]
        [HttpGet]
        public ShopModel Profile()
        {
            //string uname = User.Identity.Name;
            string uname = "shop1";
            return ShopService.GetOneShop(uname);
        }


        [Route("api/Shop/EditProfile")]
        [HttpPost]
        public void EditProfile(ShopModel n)
        {
            ShopService.Edit(n);
        }

        [Route("api/Shop/DeleteProfile")]
        [HttpPost]
        public void DeleteProfile(ShopModel n)
        {
            ShopService.Delete(n);
        }

    }
}
