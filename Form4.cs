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
using System.IO;

namespace Trabajo_final
{
    public partial class Form4 : Form
    {
        private Biblioteca biblioteca;
        private Controller controller;

        public Form4(Biblioteca biblioteca)
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

        private void registarButton_Click(object sender, EventArgs e)
        {
            try
            {
                int cedula = int.Parse(cedulaBox.Text);
                int identificador = int.Parse(identificadorBox.Text);
                int cantidad = int.Parse(cantidadBox.Text);
                Persona persona = biblioteca.Personas[cedula];

                this.controller.RegistrarPrestamo(biblioteca, cantidad, identificador, persona);
               
            } catch(Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error: " + ex.Message);
            }
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
    }
}
