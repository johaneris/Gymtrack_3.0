using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfazdeUsuario.models
{
    internal class Student
    {
        public string Name { get; set; }   
        public string Email { get; set; }   
        public string CIF { get; set; } 
        public string Password { get; set; }    

        public Student(string name, string email, string cif, string password)
        {
            Name = name;
            Email = email;
            CIF = cif;
            Password = password;
        }
    }
}
