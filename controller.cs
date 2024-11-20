using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.IO;

namespace Trabajo_final
{
    internal class Controller
    {

        public Controller()
        {}

        public bool RegistrarMaterial(Biblioteca biblioteca, Material material)
        {

            if (BuscarPorIdentificador(biblioteca, material.Identificador) != null)
            {
                throw new Exception("Existe otro material registrado con ese identificador");
            }
            biblioteca.Catalogo.Add(material);
            MessageBox.Show("Material registrado");

            escribirArchivoCatalogo(biblioteca);
            return true;
            
        }
        public Material BuscarPorIdentificador(Biblioteca biblioteca, int identificador)
        {
            foreach (Material mat in biblioteca.Catalogo)
            {
                if (mat.Identificador == identificador)
                {
                    return mat;
                }
            }
            return null;
        }
        public Persona BuscarPorCedula(Biblioteca biblioteca, int cedula)
        {
            MessageBox.Show("Cedulas registradas en el sistema: " + string.Join(", \n", biblioteca.Personas.Keys));
            Persona persona = biblioteca.Personas[cedula];
            if (persona!=null)
            {
                MessageBox.Show("Usuario encontrado: " + persona.Nombre);
                return persona;

            }

            MessageBox.Show("La cédula no está registrada en el sistema.");
            return null;

        }
        public bool EliminarPersona(Biblioteca biblioteca, int cedula)
        {
            if (biblioteca.Personas.ContainsKey(cedula))
            {
                Persona persona = biblioteca.Personas[cedula];

                if (persona.Cantidadprestamo > 0)
                {
                    MessageBox.Show("La persona tiene materiales prestados y no puede ser eliminada.");
                    return false;
                }

                biblioteca.Personas.Remove(cedula);
                MessageBox.Show("La persona con la cedula: " + cedula + ". Se ha eliminado correctamente.");
                return true;
            }
            else
            {
                MessageBox.Show("No se encontro la persona con esa cedula.");
                return false;
            }
        }
        public bool RegistrarPersona(Biblioteca biblioteca, string nombre, int cedula, string rol, int cantidadPrestamo)
        {
            if (biblioteca.Personas.ContainsKey(cedula))
            {
               
                MessageBox.Show("La cédula ya existe.");
                return false;
            }
            else
            {
                if (!rol.Equals("administrativo") && !rol.Equals("estudiante") && !rol.Equals("profesor"))
                {
                    throw new Exception("el rol es invalido");
                }
                // se agg el new List<Material>() por la lista, pero creo que esta mal  
                Persona newPersona = new Persona(ConvertirInicialesMayusculas(nombre), cedula, rol.ToLower(), 0, new List<Material>());
                biblioteca.Personas.Add(cedula, newPersona);
                MessageBox.Show("Usuario agregado.\n\nNombre: " + ConvertirInicialesMayusculas(nombre) + "\nCedula: " + cedula + "\nRol: " + ConvertirInicialesMayusculas(rol));

                //Verificacion extra
                //if (biblioteca.Personas.ContainsKey(cedula))
                //{
                //    MessageBox.Show("La persona se ha añadido correctamente al diccionario.");
                //}
                //else
                //{
                //    MessageBox.Show("La persona no se añadio al diccionario");
                //}
                return true;

            }
        }
        public string IncrementarCantidadMaterial(Biblioteca biblioteca, int cantidad, int identificador)
        {
           
            Material mat = BuscarPorIdentificador(biblioteca, identificador);
            if (mat == null)
            {
                throw new Exception("No existe un material registrado con ese identificador");
            }
            int cantidadAnterior = mat.CantidadActual;  
            mat.CantidadActual += cantidad;
            mat.CantidadRegistrada += cantidad;

            escribirArchivoCatalogo(biblioteca);

            return $"Cantidad anterior: {cantidadAnterior}, Cantidad actual: {mat.CantidadActual}";
        }
        public void RegistrarPrestamo(Biblioteca biblioteca, int cantidad, int identificador, Persona persona)
        {
            
            Persona personaRegistrada = BuscarPorCedula(biblioteca, persona.Cedula);
            if (personaRegistrada == null)
            {
                throw new Exception("La persona no está registrada en la biblioteca");
            }
            

            Material mat = BuscarPorIdentificador(biblioteca, identificador);
            if (mat == null)
            {
                throw new Exception("No existe ese material con ese identificador");
            }
            if (mat.CantidadActual < cantidad)
            {
                throw new Exception("No hay suficientes ejemplares de ese material");
            }
            if ((persona.Rol.Equals("administrativo") && personaRegistrada.MaterialesPrestados.Count + cantidad > 1) ||
                (persona.Rol.Equals("estudiante") && personaRegistrada.MaterialesPrestados.Count + cantidad > 5) ||
                (persona.Rol.Equals("profesor") && personaRegistrada.MaterialesPrestados.Count + cantidad > 3))
            {
                throw new Exception("Ha alcanzado el limite de materiales prestados");
            }

            foreach(Material prestado in personaRegistrada.MaterialesPrestados)
            {
                if(prestado.Identificador == identificador)
                {
                    throw new Exception("La persona ya tiene este material prestado");
                }
            }
            personaRegistrada.Cantidadprestamo += cantidad;
            mat.CantidadActual -= cantidad;
            MessageBox.Show("prestamo exitoso, cantidad prestada: "+ personaRegistrada.Cantidadprestamo);
            personaRegistrada.MaterialesPrestados.Add(mat);

            HistorialMovimientos historialMovimiento = new HistorialMovimientos(mat, persona, DateTime.Now, "Prestamo");
            biblioteca.HistorialMovimientos.Add(historialMovimiento);

        }
        public void RegistrarDevolucion(Biblioteca biblioteca, int cantidad, int identificador, Persona persona)
        {
                Persona personaRegistrada = BuscarPorCedula(biblioteca, persona.Cedula);

                if (personaRegistrada == null)
                {
                    throw new Exception("La persona no está registrada en la biblioteca");
                }

                // Se busca en la lista los materiales prestados de la persona
                Material materialPrestado = null;
                foreach (Material prestado in personaRegistrada.MaterialesPrestados)
                {
                    if (prestado.Identificador == identificador)
                    {
                        materialPrestado = prestado; 
                        break;
                    }
                }
                if (materialPrestado == null) {
                    throw new Exception("La persona no tiene el material prestado");
                }

                Material mat = BuscarPorIdentificador(biblioteca, identificador);

                if (mat == null)
                {
                    throw new Exception("No existe ese material con ese identificador");
                }



                if (persona.Cantidadprestamo.Equals(0))
                {
                    throw new Exception("La persona no tiene materiale prestados");
                }


                mat.CantidadActual += cantidad;
                //Codigo para registrar devolucion a la persona

                persona.Cantidadprestamo -= cantidad;
                //Codigo para registrar transaccion de devolucion
                HistorialMovimientos historialMovimiento = new HistorialMovimientos(mat, persona, DateTime.Now, "Devolución");
                biblioteca.HistorialMovimientos.Add(historialMovimiento);
                personaRegistrada.MaterialesPrestados.Remove(materialPrestado);
                
                MessageBox.Show("Se la eliminado exitosamente, materiales prestados en total:" + persona.Cantidadprestamo);
            
        }
        public void HistorialMovimientos(Biblioteca biblioteca,Persona persona)
        {
            Persona personaRegistrada = BuscarPorCedula(biblioteca, persona.Cedula);
            if (personaRegistrada == null)
            {
                throw new Exception("La persona no está registrada en la biblioteca");
            }
            

            for (int i = 0; i < biblioteca.HistorialMovimientos.Count; i++)
            {
                HistorialMovimientos movimiento = biblioteca.HistorialMovimientos[i];
                MessageBox.Show("Material: " + movimiento.Material.Titulo + "\nPersona: " + movimiento.Persona.Nombre + "\nFecha: " + movimiento.Fecha.ToString("d/MM/yyyy") +"\nTipo de Movimiento: " + movimiento.TipoMovimiento);
            }
        }
        public string ConvertirInicialesMayusculas(string nombre)
        {
            nombre = nombre.ToLower();
            TextInfo textInfo = new CultureInfo("es-ES", false).TextInfo;
            nombre = textInfo.ToTitleCase(nombre);
            return nombre;
        }
        public void escribirArchivoCatalogo(Biblioteca biblioteca)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter("../../biblioteca.txt"))
                {
                    sw.WriteLine("IDENTIFICADOR, MATERIAL, CANTIDAD_    REGISTRADA");
                    foreach (Material mat in biblioteca.Catalogo)
                    {
                        if (mat != null)
                        {
                            MessageBox.Show($"Escribiendo: {mat.Export()}");
                            sw.WriteLine(mat.Export());
                        }
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Exception: " + e.Message);
            }
            finally
            {
                MessageBox.Show("Executing finally block.");
            }
        }
        public void importarCatalogo(Biblioteca biblioteca)
        {
            String line;
            try
            {
                using (StreamReader sr = new StreamReader("../../biblioteca.txt"))
                {
                    ;

                    sr.ReadLine();

                    int pos = 0;

                    while ((line = sr.ReadLine()) != null)
                    {

                        try
                        {
                            string[] textLine = line.Split(',');
                            int identificador = int.Parse(textLine[0]);
                            string titulo = textLine[1];
                            int cantidadRegistrada = int.Parse(textLine[2]);

                            Material mat = new Material(identificador, titulo, DateTime.Now, cantidadRegistrada, cantidadRegistrada);
                            biblioteca.Catalogo.Add(mat); pos++;
                        }
                        catch (Exception e)
                        {
                            MessageBox.Show($"Error procesando línea: {line}\n{e.Message}");
                            continue;

                        }
                    }
                }

            }
            catch (Exception e)
            {
                MessageBox.Show("Exception: " + e.Message);
            }
            finally
            {
                MessageBox.Show("Executing finally block.");
            }
        }


    }
}
