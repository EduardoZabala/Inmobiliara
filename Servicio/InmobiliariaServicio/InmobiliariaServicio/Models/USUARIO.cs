//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class USUARIO
    {
        public int ID { get; set; }
        public string NombreUsuario { get; set; }
        public string Contraseña { get; set; }
        public string Email { get; set; }
        public int IDRol { get; set; }
    
        public virtual ROL ROL { get; set; }
    }
}
