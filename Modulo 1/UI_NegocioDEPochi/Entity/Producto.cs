using System;
using System.Collections.Generic;
using System.Text;

namespace Entity
{
    public class Producto
    {
        private string _nombre;
        private int _precio;

        public int Precio
        {
            get { return _precio; }
            set { _precio = value; }
        }


        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

    }
}
