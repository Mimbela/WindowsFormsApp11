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
        Form2 formulario2; //objeto form2 que está asignado como propiedad no instanciado
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
            foreach (Control x in this.Controls)
            {
                if (x is TextBox)
                {
                    ((TextBox)x).Text = string.Empty;
                }
            }
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


//Ejercicio Propuesto(Anexo 1): 
//Crear una aplicación formada por dos formularios Windows.En el primer formulario recogemos el nombre y apellido1 de un alumno.
//Igualmente, en este formulario recogemos las notas de tres asignaturas ( con un decimal). Tendrá tres botones : Aceptar(manda los datos al segundo formulario), 
//Borrar(deja todas las cajas vacias) y Salir(Cierra la aplicación).
//Con las tres notas, el segundo formulario calcula la media.Si esta es superior a 4.9 entonces mostrar una label con la leyenda:
//“Apellido1, Nombre ha superado el curso”
//Si no, “Nombre, vuelva a intentarlo otro año”
