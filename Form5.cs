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
    public partial class Form5 : Form
    {
        private Biblioteca biblioteca;
        private Controller controller;
        public Form5(Biblioteca biblioteca)
        {
            InitializeComponent();
            this.controller = new Controller();
            this.biblioteca = biblioteca;
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void registrarButton_Click(object sender, EventArgs e)
        {
            try
            {
                int identificador = int.Parse(identificadorBox.Text);
                string titulo = nombreMaterialBox.Text;
                DateTime fechaRegistro = DateTime.Now;
                int cantidadRegistrada = int.Parse(cantRegisBox.Text);

                Material nuevoMaterial = new Material(identificador, titulo, fechaRegistro, cantidadRegistrada, cantidadRegistrada);
                


                if (controller.RegistrarMaterial(biblioteca, nuevoMaterial))
                {
                    MessageBox.Show("Material registrado exitosamente" + "\n\n" +"Nombre material: "+titulo + "\n"+"Identificador: " +identificador + "\n" + "Cantidad registrada: "+cantidadRegistrada);
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
