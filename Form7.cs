using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace Trabajo_final
{
    public partial class Form7 : Form
    {
        private Biblioteca biblioteca;
        private Controller controller;
        public Form7(Biblioteca biblioteca)
        {
            InitializeComponent();
            this.controller = new Controller();
            this.biblioteca = biblioteca;

        }

        private void Form7_Load(object sender, EventArgs e)
        {

        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void incrementarButton_Click(object sender, EventArgs e)
        {
            try
            {
                int identificador = int.Parse(identMatBox.Text);
                int cantidad = int.Parse(cantidadMatBox.Text);
               

                string resultado = controller.IncrementarCantidadMaterial(biblioteca, cantidad, identificador);

                MessageBox.Show("Cantidad incrementada exitosamente");
                
            }catch(Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error: " + ex.Message);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
