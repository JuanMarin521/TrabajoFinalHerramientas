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
    public partial class Form2 : Form
    {
        private Biblioteca biblioteca;
        private Controller controller;

        public Form2(Biblioteca biblioteca)
        {
            InitializeComponent();
            this.controller = new Controller();
            this.biblioteca = biblioteca;
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void nameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void cedulaBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }


        private void acceptButton_Click(object sender, EventArgs e)
        {
            try
            {
                string nombre = nameBox.Text;
                this.controller.ConvertirInicialesMayusculas(nombre);

                int cedula = int.Parse(cedulaBox.Text);
                string rol = rolBox.Text.ToLower();

                bool registrado = controller.RegistrarPersona(biblioteca, nombre, cedula, rol, 0);
                
                if(registrado)
                {
                    MessageBox.Show("Se ha registrado correctamente");
                }
                else
                {
                    MessageBox.Show("No se ha registrado");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error: "+ ex.Message);
            }
        }

 

        private void labelNombre_Click(object sender, EventArgs e)
        {
           
        }


        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
