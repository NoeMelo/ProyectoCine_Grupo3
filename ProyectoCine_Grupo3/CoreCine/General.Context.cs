﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CoreCine
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class CineDBEntities : DbContext
    {
        public CineDBEntities()
            : base("name=CineDBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Asiento> Asiento { get; set; }
        public virtual DbSet<Cine> Cine { get; set; }
        public virtual DbSet<CinePelicula> CinePelicula { get; set; }
        public virtual DbSet<Director> Director { get; set; }
        public virtual DbSet<Funcion> Funcion { get; set; }
        public virtual DbSet<Interprete> Interprete { get; set; }
        public virtual DbSet<Pelicula> Pelicula { get; set; }
        public virtual DbSet<Persona> Persona { get; set; }
        public virtual DbSet<Protagonista> Protagonista { get; set; }
        public virtual DbSet<Sala> Sala { get; set; }
        public virtual DbSet<Ticket> Ticket { get; set; }
    }
}
