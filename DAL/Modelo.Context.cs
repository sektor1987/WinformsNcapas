﻿//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Entities_ : DbContext
    {
        public Entities_()
            : base("name=Entities_")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<TBL_AUTENTIFICACION> TBL_AUTENTIFICACION { get; set; }
        public DbSet<TBL_DIAFESTIVO> TBL_DIAFESTIVO { get; set; }
        public DbSet<TBL_ESTADO> TBL_ESTADO { get; set; }
        public DbSet<TBL_ESTADOSOLICITUDPERMISO> TBL_ESTADOSOLICITUDPERMISO { get; set; }
        public DbSet<TBL_MODULO> TBL_MODULO { get; set; }
        public DbSet<TBL_PERMISO> TBL_PERMISO { get; set; }
        public DbSet<TBL_PERMISOUSUARIO> TBL_PERMISOUSUARIO { get; set; }
        public DbSet<TBL_REG_ERRORES> TBL_REG_ERRORES { get; set; }
        public DbSet<TBL_REGISTROASISTENCIA> TBL_REGISTROASISTENCIA { get; set; }
        public DbSet<TBL_REGISTROFUNCIONARIO> TBL_REGISTROFUNCIONARIO { get; set; }
        public DbSet<TBL_ROL> TBL_ROL { get; set; }
        public DbSet<TBL_SITUACION> TBL_SITUACION { get; set; }
        public DbSet<TBL_SOLICITUDPERMISO> TBL_SOLICITUDPERMISO { get; set; }
        public DbSet<TBL_UNIDADINTERNA> TBL_UNIDADINTERNA { get; set; }
        public DbSet<TBL_USUARIO> TBL_USUARIO { get; set; }
    }
}
