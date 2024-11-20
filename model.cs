using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.IO;

namespace Trabajo_final
{
    #region Biblioteca
    public class Biblioteca
    {
        private List<Material> catalogo;
        private Dictionary<int, Persona> personas;
        private List<HistorialMovimientos> historialMovimientos;

        // Constructor sin parámetros para inicializar los campos
        public Biblioteca() { 
            this.catalogo = new List<Material>();
            this.personas = new Dictionary<int, Persona>();
            this.historialMovimientos = new List<HistorialMovimientos>(); 
        }

        public Biblioteca(List<Material> catalogo, Dictionary<int, Persona> personas, List<HistorialMovimientos> historialMovimientos)
        {
            this.Catalogo = catalogo;
            this.Personas = personas;
            this.HistorialMovimientos = historialMovimientos;
            
        }

        public List<Material> Catalogo { get => catalogo; set => catalogo = value; }
        public Dictionary<int, Persona> Personas { get => personas; set => personas = value; }
        public List<HistorialMovimientos> HistorialMovimientos { get => historialMovimientos; set => historialMovimientos = value; }
    }
    #endregion 

    #region Material
    public class Material
    {
        private int identificador;
        private string titulo;
        private DateTime fecha_registro;
        private int cantidadRegistrada;
        private int cantidadActual;

        public Material(int identificador, string titulo, DateTime fecha_registro, int cantidadRegistrada, int cantidadActual)
        {
            this.Identificador = identificador;
            this.Titulo = titulo;
            this.Fecha_registro = fecha_registro;
            this.CantidadRegistrada = cantidadRegistrada;
            this.CantidadActual = cantidadActual;
        }

        public int Identificador { get => identificador; set => identificador = value; }
        public string Titulo { get => titulo; set => titulo = value; }
        public DateTime Fecha_registro { get => fecha_registro; set => fecha_registro = value; }
        public int CantidadRegistrada { get => cantidadRegistrada; set => cantidadRegistrada = value; }
        public int CantidadActual { get => cantidadActual; set => cantidadActual = value; }

        //public String ToString()
        // {
        //     return "Identificador: " + identificador +
        //         "\nTitulo: " + titulo +
        //         "\nFecha registro: " + fecha_registro +
        //         "\nCantidad registrada: " + CantidadRegistrada +
        //         "\nCantidadActual: " + CantidadActual;
        // }



        //public String Export()
        //{
        //    return this.identificador + ", " + this.titulo + ", " + this.fecha_registro + "," + this.CantidadRegistrada + "," + this.cantidadActual;
        //}

        public string Export() { return $"{Identificador},{Titulo},{CantidadRegistrada}"; }
        public override string ToString()
        {
            return $"Identificador: {Identificador}\nTitulo: {Titulo}\nCantidad registrada: {CantidadRegistrada}";
        }
    }
    #endregion

    #region Persona
    public class Persona
    {
        private string nombre;
        private int cedula;
        private string rol;
        private int cantidadprestamo;
        private List<Material> materialesPrestados;

        public Persona(string nombre, int cedula, string rol, int cantidadprestamo, List<Material> materialesPrestados)
        {
            this.Nombre = nombre;
            this.Cedula = cedula;
            this.Rol = rol;
            this.Cantidadprestamo = cantidadprestamo;
            this.MaterialesPrestados = materialesPrestados;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public int Cedula { get => cedula; set => cedula = value; }
        public string Rol { get => rol; set => rol = value; }
        public int Cantidadprestamo { get => cantidadprestamo; set => cantidadprestamo = value; }
        public List<Material> MaterialesPrestados { get => materialesPrestados; set => materialesPrestados = value; }
    }
    #endregion

    #region Movimientos
    public class HistorialMovimientos
    {
        private Material material;
        private Persona persona;
        private DateTime fecha;
        private string tipoMovimiento;

        public HistorialMovimientos(Material material, Persona persona, DateTime fecha, string tipoMovimiento)
        {
            this.Material = material;
            this.Persona = persona;
            this.Fecha = fecha;
            this.TipoMovimiento = tipoMovimiento;
        }

        public Material Material { get => material; set => material = value; }
        public Persona Persona { get => persona; set => persona = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public string TipoMovimiento { get => tipoMovimiento; set => tipoMovimiento = value; }

      
        
    }
    #endregion

}
