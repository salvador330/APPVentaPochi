using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Entity;

namespace UI_NegocioDEPochi
{
    public partial class Pantalla_Principal : Form
    {
        public Pantalla_Principal()
        {
            InitializeComponent();
        }

        private Uusario _DatosComportidos;

        public Uusario DatosComportidos
        {
            get { return _DatosComportidos; }
            set { _DatosComportidos = value; }
        }


        private void Pantalla_Principal_Load(object sender, EventArgs e)
        {
            label2.Text = DatosComportidos.Nombre;
        }
    }
}
