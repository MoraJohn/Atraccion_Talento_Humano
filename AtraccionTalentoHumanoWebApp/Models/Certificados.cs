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
    
    public partial class Certificados
    {
        public int Id_Certificado { get; set; }
        public string NombreCertificado { get; set; }
        public short Horas { get; set; }
        public System.DateTime Emitido { get; set; }
        public string Emisor { get; set; }
        public int Cod_Usuario { get; set; }
    
        public virtual Usuarios Usuarios { get; set; }
    }
}