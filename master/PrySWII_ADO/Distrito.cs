//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PrySWII_ADO
{
    using System;
    using System.Collections.Generic;
    
    public partial class Distrito
    {
        public Distrito()
        {
            this.Empleado = new HashSet<Empleado>();
            this.Paciente = new HashSet<Paciente>();
        }
    
        public string IdDistrito { get; set; }
        public string Nombre { get; set; }
    
        public virtual ICollection<Empleado> Empleado { get; set; }
        public virtual ICollection<Paciente> Paciente { get; set; }
    }
}
