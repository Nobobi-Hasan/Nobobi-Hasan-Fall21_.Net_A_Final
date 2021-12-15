using BEL;
using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using System.Web.Script.Serialization;

namespace ApiApp.Controllers
{
    [EnableCors("*", "*", "*")]
    public class CustomerController : ApiController
    {
        [Route("api/Customer/AddToCart/{bId}")]
        [HttpPost]
        public void AddToCart(int bId)
        {
            CartService.AddToCart(bId, "Shatin");
        }

        [Route("api/Customer/OneBook/{bId}")]
        [HttpGet]
        public BookModel OneBook(int bId)
        {

            return BookService.GetOne(bId);
        }


        [Route("api/Customer/AllBooks")]
        [HttpGet]
        public List<BookModel> GetAllBooks()
        {

            return BookService.GetAll();
        }
    }
}
