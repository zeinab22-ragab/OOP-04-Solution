using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOP_04.Q2.Interface;

namespace OOP_04.Q2
{
    public class BasicAuthenticationService : IAuthenticationService
    {
        public bool AuthenticateUser(string username, string password)
        {
            return username == "admin" && password == "123456";
        }

        public bool AuthorizeUser(string username, string role)
        {
            return username == "admin" && role == "Adminatrator";
        }
    }
}
