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
        [Route("api/Shop/Book/Add")]
        [HttpPost]
        public void Add(BookModel b)
        {
            //string sName = User.Identity.Name;
            //int id = Int32.Parse(sId);
            b.ShopName = "shop1";
            BookService.Add(b);
        }

        [Route("api/Shop/Book/GetByUsername/")]
        [HttpGet]
        public List<BookModel> GetByUsername()
        {
            //string sName = User.Identity.Name;
            return BookService.GetByUsername("shop1");
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



        
    }
}
