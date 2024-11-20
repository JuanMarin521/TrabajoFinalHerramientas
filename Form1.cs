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
    public partial class UserControl1 : Form
    {
        private Biblioteca biblioteca;
        private Controller controller;
        private Persona persona;

        public UserControl1(Biblioteca biblioteca)
        {
            InitializeComponent();

            //Se invoca el metodo en el constructor justo despues de inicializar componentes
            personalizarDiseño();
            this.controller = new Controller();
            this.biblioteca = new Biblioteca(new List<Material>(), new Dictionary<int, Persona>(),new List<HistorialMovimientos>());
            this.controller.importarCatalogo(this.biblioteca);
            MessageBox.Show("Se ha creado la biblioteca");

        }
     

        //Codificacion 27/10/2024

        private void personalizarDiseño()
        {
            //Oculta los paneles del submenu
            panelObjetosSubMenu.Visible = false;
            panelPersonasSubMenu.Visible = false;
        }
        private void ocultarSubMenu()
        {
            //Si el panel objetos se encuentra desplegado lo cerrará
            if (panelObjetosSubMenu.Visible == true)
                panelObjetosSubMenu.Visible = false;
            //Si el panel personas se encuentra desplegado lo cerrará
            if (panelPersonasSubMenu.Visible == true)
                panelPersonasSubMenu.Visible = false;
        }

        //Todos los submenus son paneles, entonces se tomará como parametro de tipo panel1 submenu
        private void mostrarSubMenu(Panel subMenu)
        {
            //Si panel submenu está oculto, se mostrará
            if (subMenu.Visible == false)
            {
                //Se invoca en caso de que haya algun submenu abierto
                ocultarSubMenu();

                //Se muestra el submenu
                subMenu.Visible = true;
            }
            else
            {
                //Si el submenu se encuentra abierto se volverá a ocultar
                subMenu.Visible = false;
            }
        }
        private Form formularioActivo = null;

        private void abrirFormulariosHijos(Form formularioHijo)
        {
            //Si existe algun formulario activo
            if (formularioActivo != null)

                //Se cierra el formulario
                formularioActivo.Close();

            //Se guarda el formulario que se abre en la variable formulario activo
            formularioActivo = formularioHijo;

            //Se indica que el formulario hijo no es de nivel superior
            //Se comportará igual que un control
            formularioHijo.TopLevel = false;

            //Se quita el borde del formulario
            formularioHijo.FormBorderStyle = FormBorderStyle.None;

            //Se establece la propiedad para llenar todo el formulario contenedor(principal)
            formularioHijo.Dock = DockStyle.Fill;

            //Agregamos el formulario a la lista de controles del panel contenedor
            panelFormularioHijo.Controls.Add(formularioHijo);

            //Se asocia el formulario con el panel contenedor
            panelFormularioHijo.Tag = formularioHijo;

            //En caso de poner logos en el panel
            formularioHijo.BringToFront();
            //Se muestra el formulario hijo
            formularioHijo.Show();
        }

        #region Personas

        private void botonPersonas_Click(object sender, EventArgs e)
        {
            mostrarSubMenu(panelPersonasSubMenu);
        }

        private void btnRegistrarPersona_Click(object sender, EventArgs e)
        {
            abrirFormulariosHijos(new Form2(biblioteca));
            //Codigo para registrar personas
            Form2 form2 = new Form2(biblioteca); 
   
            ocultarSubMenu();
        }

        private void btnEliminarPersona_Click(object sender, EventArgs e)
        {
            abrirFormulariosHijos(new Form3(biblioteca));
            //Codigo para eliminar personas
            Form3 form3 = new Form3(biblioteca); 
            ocultarSubMenu();
        }

        #endregion

        private void botonObjetos_Click(object sender, EventArgs e)
        {
            mostrarSubMenu(panelObjetosSubMenu);
        }

        private void btnRegistrarPrestamo_Click(object sender, EventArgs e)
        {
            abrirFormulariosHijos(new Form4(biblioteca));
            //Codigo para registrar prestamo
            ocultarSubMenu();

        }

        private void btnRegistrarMaterial_Click(object sender, EventArgs e)
        {
            abrirFormulariosHijos(new Form5(biblioteca));
            //Codigo para registrar devolucion de material
            ocultarSubMenu();
        }

        private void btnRegistrarDevolucion_Click(object sender, EventArgs e)
        {
            abrirFormulariosHijos(new Form6(biblioteca));
            //Codigo para registrar objeto
            ocultarSubMenu();
        }

        private void btnIncreCantiObjetos_Click(object sender, EventArgs e)
        {
            abrirFormulariosHijos(new Form7(biblioteca));
            //Codigo para imcrementar cantidad objetos
            ocultarSubMenu();
        }

        private void botonHistorial_Click(object sender, EventArgs e)
        {
            abrirFormulariosHijos(new Form8(biblioteca,persona));
            //Codigo para consultar historial
            ocultarSubMenu();
        }

        private void panelFormularioHijo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelInferior_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panelPersonasSubMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelObjetosSubMenu_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
