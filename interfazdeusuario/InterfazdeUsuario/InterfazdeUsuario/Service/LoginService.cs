using InterfazdeUsuario.models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace InterfazdeUsuario.Service
{
    public class LoginService
    {


        private string FilePath = "adminData.bin";

        Admin admin;

        //constructor

        public LoginService()
        {
            //guardar la la contra y el user 
            if (!File.Exists(FilePath))
            {
                SaveData("Administrador", "Uam123");
            }
            else
            {
                LoadAdmin();
            }
        }

        private void SaveData(string user, string password)
        {
            FileStream fs = new FileStream(FilePath, FileMode.Create, FileAccess.Write);
            BinaryWriter bw = new BinaryWriter(fs);

            //escribir el usuario y la contra :3

            bw.Write(user);
            bw.Write(password);

            //cerrar el archivo 
            bw.Close();
            fs.Close();
        }

        //cargar el usuario desde el binario

        public void LoadAdmin()
        {
            if (File.Exists(FilePath))
            {
                FileStream fs = new FileStream(FilePath, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);

                //leer los datos del user y la pass

                string User = br.ReadString();
                string Password = br.ReadString();

                //cerrar una vez que ha leido

                //guardar los datos en el objeto

                admin = new Admin(User, Password);

                br.Close();
                fs.Close();
            }
            else
            {
                admin = null;
            }
           

        }


        //auenticar

        public string Authenticate( string user, string password)
        {
            if(admin == null)
            {

                return "no se encontraron datos";
            }

            if (admin.User != user)
            {
                return "Su usuario es incorrecto";
            }

            if (admin.Password != password)
            {
                return "contraseña incorrecta";
            }

            if(admin.User != user && admin.Password != password)
            {
                return "usuario y contraseña incorrectos";
            }

            return "ok";
            
            

        }


        //public string GetUser()
        //{
        //    return admin != null ? admin.User : null;
        //}

        //public string Getpassword()
        //{
        //    return admin != null ? admin.Password : null;

        //}

        //public void UptadePassword(string newpassword)
        //{
        //    if (admin != null)
        //    {
        //        admin.Password = newpassword;
        //        SaveData(admin.User, newpassword);
        //    }
            
        //}

    }
}
