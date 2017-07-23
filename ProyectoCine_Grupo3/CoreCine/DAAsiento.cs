using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreCine
{
    public class DAAsiento
    {

        static public List<Asiento> listado()
        {
            List<Asiento> listado = new List<Asiento>();

            using (var data = new CineDBEntities())
            {
                listado = data.Asiento.ToList();
            }

            return listado;
        }

        static bool RegistrarAsiento(Asiento asiento)
        {
            bool exito = true;
            using (var data = new CineDBEntities)
            {
                data.Asiento.Add(asiento);
                data.SaveChanges();
            }

            return exito;
        }

        static bool EliminarAlumno(string codAsiento)
        {
            bool exito = true;

            using (var data = new CineDBEntities())
            {
                Asiento actual = data.Asiento.Where(x => x.CodAsiento == codAsiento).FirstOrDefault();
                data.Asiento.Remove(actual);
                data.SaveChanges();
            }

            return exito;
        }


    }
}
