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
    public partial class Form3 : Form
    {
        private Biblioteca biblioteca;
        private Controller controller;

        public Form3(Biblioteca biblioteca)
        {
            InitializeComponent();
            this.controller = new Controller();
            this.biblioteca = biblioteca;
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cedulaBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void eliminarButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Usuarios en la biblioteca antes de eliminar: " + string.Join(", ", biblioteca.Personas.Keys));
            try
            {
                int cedula = int.Parse(cedulaBox.Text);
                bool eliminado = this.controller.EliminarPersona(this.biblioteca, cedula);

                if (eliminado)
                {
                    MessageBox.Show("La persona se ha eliminado correctame");
                }

            }catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error: "+ ex.Message);
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
