﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DL
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class AlumnoEntities : DbContext
    {
        public AlumnoEntities()
            : base("name=AlumnoEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Carrera> Carreras { get; set; }
        public virtual DbSet<Grupo> Grupoes { get; set; }
        public virtual DbSet<Plantel> Plantels { get; set; }
        public virtual DbSet<Sistema> Sistemas { get; set; }
    
        public virtual ObjectResult<CarreraGetByIdPlantel_Result> CarreraGetByIdPlantel(Nullable<int> idPlantel)
        {
            var idPlantelParameter = idPlantel.HasValue ?
                new ObjectParameter("IdPlantel", idPlantel) :
                new ObjectParameter("IdPlantel", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<CarreraGetByIdPlantel_Result>("CarreraGetByIdPlantel", idPlantelParameter);
        }
    
        public virtual ObjectResult<GrupoGetByIdCarrera_Result> GrupoGetByIdCarrera(Nullable<int> idCarrera)
        {
            var idCarreraParameter = idCarrera.HasValue ?
                new ObjectParameter("IdCarrera", idCarrera) :
                new ObjectParameter("IdCarrera", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GrupoGetByIdCarrera_Result>("GrupoGetByIdCarrera", idCarreraParameter);
        }
    
        public virtual ObjectResult<PlatenlGetByIdSistema_Result> PlatenlGetByIdSistema(Nullable<int> idSistema)
        {
            var idSistemaParameter = idSistema.HasValue ?
                new ObjectParameter("IdSistema", idSistema) :
                new ObjectParameter("IdSistema", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<PlatenlGetByIdSistema_Result>("PlatenlGetByIdSistema", idSistemaParameter);
        }
    
        public virtual ObjectResult<SistemaGetAll_Result> SistemaGetAll()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SistemaGetAll_Result>("SistemaGetAll");
        }
    }
}
