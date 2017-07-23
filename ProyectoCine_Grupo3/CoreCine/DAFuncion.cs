using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreCine
{
    public class DAFuncion
    {
        static public List<Funcion> listadoFuncion()
        {
            List<Funcion> listado = new List<Funcion>();
            using (var data = new CineDBEntities())
            {
                return data.Funcion.ToList();
            }
        }

        static public bool RegistrarFuncion(Funcion Funcion)
        {
            bool exito = true;
            try
            {
                using (var data = new CineDBEntities())
                {
                    data.Funcion.Add(Funcion);
                    data.SaveChanges();
                }
            }
            catch
            {

                exito = false;
            }

            return exito;
        }

        static public bool ActualizarAlumno(Funcion Funcion)
        {
            bool exito = true;
            try
            {
                using (var data = new CineDBEntities())
                {
                    Funcion actual = data.Funcion.Where(x => x.CodFuncion == Funcion.CodFuncion).FirstOrDefault();
                    actual.CodFuncion = Funcion.CodFuncion;
                    actual.HoraInicio = Funcion.HoraInicio;
                    actual.HoraFin = Funcion.HoraFin;
                    actual.CodPelicula = Funcion.CodPelicula;
                    actual.FechaFuncion = Funcion.FechaFuncion;
                    actual.Precio = Funcion.Precio;
                    data.SaveChanges();
                }

            }
            catch (Exception)
            {

                exito = false;
            }
            return exito;
        }
        static public bool EliminarFuncion(Funcion Funcion)
        {
            bool exito = true;
            try
            {
                using (var data = new CineDBEntities())
                {
                    Funcion actual = data.Funcion.Where(x => x.CodFuncion == Funcion.CodFuncion).FirstOrDefault();
                    data.Funcion.Remove(actual);
                    data.SaveChanges();
                }
            }
            catch (Exception)
            {

                exito = false;
            }
            return exito;
        }
    }
}
