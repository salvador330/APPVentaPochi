using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entity;

namespace UI_NegocioDEPochi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Uusario unUsuario = new Uusario();
        private void Form1_Load(object sender, EventArgs e)
        {
            
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            unUsuario.Nombre = textBox1.Text;
            unUsuario.Password = textBox2.Text;
            Pantalla_Principal otroForm = new Pantalla_Principal();
            otroForm.DatosComportidos = unUsuario;
            otroForm.Show();
        }
    }
}
