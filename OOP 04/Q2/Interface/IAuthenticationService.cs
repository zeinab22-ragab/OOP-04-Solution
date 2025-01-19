using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_04.Q2.Interface
{
    public interface IAuthenticationService
    {
        bool AuthenticateUser(string username, string password); 
        bool  AuthorizeUser(string username, string role);


    }
}
