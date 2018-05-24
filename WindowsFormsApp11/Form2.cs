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
    public partial class Form2 : Form
    {
        decimal media;
        string nombre, apellido;
        public Form2()
        {
            InitializeComponent();
            
        }
        //es el formulario importante
        public void CalcularMedia(decimal valor1, decimal valor2, decimal valor3){ //hago metodo para la suma
            
            decimal suma = decimal.Round (valor1) + decimal.Round( valor2 )+ decimal.Round (valor3); //decimal.round redondea el decimal
             media = decimal.Round (suma / 3);

            ImprimirNota();
        }

        private void ImprimirNota()
        {
            txtNedia.Text  = media.ToString();
            if (media>=5)
            {
                //has aprobado
                label2.Text = string.Format("{0} - {1} has aprobado", nombre, apellido);
                label2.Visible = true; //para que enseñe los datos recogidos
            }
            else
            {
                label2.Text = string.Format("{0} - {1} vuelve a intentarlo otros año", nombre, apellido);
                label2.Visible = true;
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void RecibirNombre(string nomb, string apell)
        {
            nombre = nomb;
            apellido = apell;
        }
    }
}
