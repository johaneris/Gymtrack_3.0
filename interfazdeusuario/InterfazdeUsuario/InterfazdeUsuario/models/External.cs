using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfazdeUsuario.models
{
    internal class External
    {
        public string Name { get; set; }    
        public string Email { get; set; }   
        public string Cedula { get; set; }  
        public string Password { get; set; }

        public External(string name, string email, string cedula, string password)
        {
           Name = name;
           Email = email;
           Cedula = cedula;
           Password = password;
        }
    }
}
