using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreCine
{
    public class DACinePelicula
    {
        static public List<CinePelicula> listadoCinePelicula()
        {
            List<CinePelicula> listado = new List<CinePelicula>();
            using (var data = new CineDBEntities())
            {
                return data.CinePelicula.ToList();
            }
        }

        static public bool RegistrarCinePelicula(CinePelicula CinePelicula)
        {
            bool exito = true;
            try
            {
                using (var data = new CineDBEntities())
                {
                    data.CinePelicula.Add(CinePelicula);
                    data.SaveChanges();
                }
            }
            catch
            {

                exito = false;
            }

            return exito;
        }

        static public bool ActualizarCinePelicula(CinePelicula CinePelicula)
        {
            bool exito = true;
            try
            {
                using (var data = new CineDBEntities())
                {
                    CinePelicula actual = data.CinePelicula.Where(x => x.CodCine == CinePelicula.CodCine).FirstOrDefault();
                    actual.CodCine = CinePelicula.CodCine;
                    actual.CodPelicula = CinePelicula.CodPelicula;
                    actual.EnCartelera = CinePelicula.EnCartelera;
                    data.SaveChanges();
                }

            }
            catch (Exception)
            {

                exito = false;
            }
            return exito;
        }
        static public bool EliminarCinePelicula(CinePelicula CinePelicula)
        {
            bool exito = true;
            try
            {
                using (var data = new CineDBEntities())
                {
                    CinePelicula actual = data.CinePelicula.Where(x => x.CodCine == CinePelicula.CodCine).FirstOrDefault();
                    data.CinePelicula.Remove(actual);
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
