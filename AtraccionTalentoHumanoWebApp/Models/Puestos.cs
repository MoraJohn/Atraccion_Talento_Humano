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
    
    public partial class Puestos
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Puestos()
        {
            this.Puestos_Usuario = new HashSet<Puestos_Usuario>();
        }
    
        public int Cod_Puesto { get; set; }
        public string NombrePuesto { get; set; }
        public string ReqLicencia { get; set; }
        public string ReqEscolaridad { get; set; }
        public string ReqTitulo { get; set; }
        public bool Activo { get; set; }
        public int Cod_AreaProfesional { get; set; }
    
        public virtual AreasProfesionales AreasProfesionales { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Puestos_Usuario> Puestos_Usuario { get; set; }
    }
}