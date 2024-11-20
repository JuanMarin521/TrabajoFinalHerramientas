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
    public partial class Form6 : Form
    {
        private Biblioteca biblioteca;
        private Controller controller;
        public Form6(Biblioteca biblioteca)
        {
            InitializeComponent();
            this.controller = new Controller();
            this.biblioteca = biblioteca;
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void aceptButton_Click(object sender, EventArgs e)
        {
            try
            {
                int cedula = int.Parse(cedulaBox.Text);
                int identificador = int.Parse(identMatBox.Text);
                int cantidad = int.Parse(CantidadBox.Text);

                Persona persona = biblioteca.Personas[cedula];

                this.controller.RegistrarDevolucion(biblioteca, cantidad, identificador, persona);

            }catch(Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error: " + ex.Message);
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
