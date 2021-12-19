using BEL;
using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ApiApp.Controllers
{
    public class AuthController : ApiController
    {
        [Route("api/login")]
        [HttpPost]
        public HttpResponseMessage Login(LoginModel user)
        {
            var token = AuthService.Authenticate(user);
            if (token != null)
            {
                return Request.CreateResponse(HttpStatusCode.OK, token);
            }

            return Request.CreateResponse(HttpStatusCode.NotFound, "User Not Found");
        }
    }
}
