﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace InmobiliariaServicio.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class INMOBILIARIAEntities : DbContext
    {
        public INMOBILIARIAEntities()
            : base("name=INMOBILIARIAEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<ARRENDAMIENTO> ARRENDAMIENTOes { get; set; }
        public virtual DbSet<ASESOR> ASESORs { get; set; }
        public virtual DbSet<CIUDAD> CIUDADs { get; set; }
        public virtual DbSet<CLIENTE> CLIENTEs { get; set; }
        public virtual DbSet<CONSULTOR> CONSULTORs { get; set; }
        public virtual DbSet<DUENIO> DUENIOs { get; set; }
        public virtual DbSet<EMPLEADO> EMPLEADOes { get; set; }
        public virtual DbSet<GERENTE> GERENTEs { get; set; }
        public virtual DbSet<PAGOARRIENDO> PAGOARRIENDOes { get; set; }
        public virtual DbSet<PAI> PAIS { get; set; }
        public virtual DbSet<PROPIEDAD> PROPIEDADs { get; set; }
        public virtual DbSet<ROL> ROLs { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<TIPOPROPIEDAD> TIPOPROPIEDADs { get; set; }
        public virtual DbSet<USUARIO> USUARIOS { get; set; }
        public virtual DbSet<VENTA> VENTAs { get; set; }
    }
}
