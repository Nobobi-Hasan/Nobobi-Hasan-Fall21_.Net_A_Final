using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public interface IAuth
    {
        Token Authenticate(Login user);
        bool IsAuthenticated(string token);
        void Logout(string token);

    }
}
