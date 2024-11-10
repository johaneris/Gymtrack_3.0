using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.RightsManagement;
using System.Text;
using System.Threading.Tasks;

namespace InterfazdeUsuario.models
{
    public class Administrador
    {
        public string User {  get; set; }
        public string Password { get; set; }


        //constructor 

        public Administrador(string user, string password)
        {
            User = user;
            Password = password;

        }


    }
}
