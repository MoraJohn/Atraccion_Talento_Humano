//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AtraccionTalentoHumanoWebApp.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Puestos_Usuario
    {
        public int Id_Puestos_Usuario { get; set; }
        public int Cod_Usuario { get; set; }
        public int Cod_Puesto { get; set; }
    
        public virtual Puestos Puestos { get; set; }
        public virtual Usuarios Usuarios { get; set; }
    }
}
