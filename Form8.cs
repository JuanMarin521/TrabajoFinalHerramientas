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
    public partial class Form8 : Form
    {
        private Biblioteca biblioteca;
        private Controller controller;
        private Persona persona;
        public Form8(Biblioteca biblioteca,Persona persona)
        {
            InitializeComponent();
            this.controller = new Controller();
            this.biblioteca = biblioteca;
            this.persona = persona;
        
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form8_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

      
                if(biblioteca.HistorialMovimientos.Count== 0)
                {
                    MessageBox.Show("No hay movimientos registrados en la biblioteca");
                    return;
                }

                this.controller.HistorialMovimientos(biblioteca, persona);              

            } catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error: " + ex.Message);
            }
        }

       

        private void cedulaBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
