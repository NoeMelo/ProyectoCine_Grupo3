using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreCine
{
    public class DACine
    {

        static public List<Cine> listado()
        {
            List<Cine> listado = new List<Cine>();

            using (var data = new CineDBEntities())
            {
                listado = data.Cine.ToList();
            }

            return listado;
        }

        static bool RegistrarCine(Cine cine)
        {
            bool exito = true;
            using (var data = new CineDBEntities)
            {
                data.Cine.Add(Cine);
                data.SaveChanges();
            }

            return exito;
        }

        static bool EliminarAlumno(string codCine)
        {
            bool exito = true;

            using (var data = new CineDBEntities())
            {
                Cine actual = data.Cine.Where(x => x.CodCine == codCine).FirstOrDefault();
                data.Cine.Remove(actual);
                data.SaveChanges();
            }

            return exito;
        }


    }
}
