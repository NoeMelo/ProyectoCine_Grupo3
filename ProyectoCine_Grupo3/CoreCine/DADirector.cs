﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreCine
{
    public class DADirector
    {
        static public List<Director> listadoDirector()
        {
            List<Director> listado = new List<Director>();
            using (var data = new CineDBEntities())
            {
                return data.Director.ToList();
            }
        }

        static public bool RegistrarDirector(Director Director)
        {
            bool exito = true;
            try
            {
                using (var data = new CineDBEntities())
                {
                    data.Director.Add(Director);
                    data.SaveChanges();
                }
            }
            catch
            {

                exito = false;
            }

            return exito;
        }

        static public bool ActualizarDirector(Director Director)
        {
            bool exito = true;
            try
            {
                using (var data = new CineDBEntities())
                {
                    Director actual = data.Director.Where(x => x.CodDirector == Director.CodDirector).FirstOrDefault();
                    actual.CodDirector = Director.CodDirector;
                    actual.NombreDirector = Director.NombreDirector;
                    data.SaveChanges();
                }

            }
            catch (Exception)
            {

                exito = false;
            }
            return exito;
        }
        static public bool EliminarDirector(Director Director)
        {
            bool exito = true;
            try
            {
                using (var data = new CineDBEntities())
                {
                    Director actual = data.Director.Where(x => x.CodDirector == Director.CodDirector).FirstOrDefault();
                    data.Director.Remove(actual);
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
