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
    
    public partial class Usuarios
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Usuarios()
        {
            this.Certificados = new HashSet<Certificados>();
            this.Idiomas = new HashSet<Idiomas>();
            this.Licencias = new HashSet<Licencias>();
            this.Puestos_Usuario = new HashSet<Puestos_Usuario>();
            this.Titulos = new HashSet<Titulos>();
        }
    
        public int Cod_Usuario { get; set; }
        public string Correo { get; set; }
        public string Identificacion { get; set; }
        public string Nombre { get; set; }
        public string Apellido1 { get; set; }
        public string Apellido2 { get; set; }
        public string Direccion { get; set; }
        public string TelefonoMovil { get; set; }
        public string TelefonoFijo { get; set; }
        public string Nacionalidad { get; set; }
        public string Tipo { get; set; }
        public string Estado { get; set; }
        public System.DateTime FechaIngresoSistema { get; set; }
        public System.DateTime UltimaVisita { get; set; }
        public string EstadoCivil { get; set; }
        public string Genero { get; set; }
        public bool Discapacidad { get; set; }
        public int Cod_Distrito { get; set; }
        public int Cod_Escolaridad { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Certificados> Certificados { get; set; }
        public virtual Curriculums Curriculums { get; set; }
        public virtual Distritos Distritos { get; set; }
        public virtual Escolaridades Escolaridades { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Idiomas> Idiomas { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Licencias> Licencias { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Puestos_Usuario> Puestos_Usuario { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Titulos> Titulos { get; set; }
    }
}