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
    
    public partial class UsuMedico
    {
        public string IdUsuario { get; set; }
        public string usuario { get; set; }
        public string contraseña { get; set; }
        public string estado { get; set; }
        public string rol { get; set; }
        public string IdEmpleado { get; set; }
    
        public virtual Empleado Empleado { get; set; }
    }
}
