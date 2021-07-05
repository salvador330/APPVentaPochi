using System;
using System.Collections.Generic;
using System.Text;

namespace Entity
{
    public class Uusario
    {
        private string _nombre;
        private string _password;
        private string _rol;

        public string Rol
        {
            get { return _rol; }
            set { _rol = value; }
        }


        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }


        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

    }
}
