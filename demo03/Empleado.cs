//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace demo03
{
    using demo03.Models;
    using System;
    using System.Collections.Generic;
    [System.ComponentModel.DataAnnotations.MetadataType(typeof(Validar_empleado))]
    
    public partial class Empleado
    {
        public int Codigo { get; set; }
        public string Apellido { get; set; }
        public string Nombre { get; set; }
        public Nullable<System.DateTime> Fnacimiento { get; set; }
        public string Cargo { get; set; }
        public string Sexo { get; set; }
        public string Fcontrato { get; set; }
        public Nullable<int> Telefono { get; set; }
        public string Email { get; set; }
        public Nullable<int> Dni { get; set; }
    }
}