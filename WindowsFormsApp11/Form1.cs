using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp11
{
    public partial class Form1 : Form
    {
        Form2 formulario2;
        public Form1()//constructor
        {
            InitializeComponent();
            formulario2 = new Form2();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit(); //cierro la aplicación
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {

            formulario2.RecibirNombre(txtNombre.Text, txtApellido.Text);
            formulario2.CalcularMedia(Convert.ToDecimal(txtAsignatura1.Text), Convert.ToDecimal(txtAsignatura2.Text), Convert.ToDecimal(txtAsignatura3.Text));
            formulario2.Show();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}


