//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class TBL_PERMISO
    {
        public TBL_PERMISO()
        {
            this.TBL_SOLICITUDPERMISO = new HashSet<TBL_SOLICITUDPERMISO>();
            this.TBL_PERMISOUSUARIO = new HashSet<TBL_PERMISOUSUARIO>();
        }
    
        public decimal ID_PERMISO { get; set; }
        public string RECURSO_LEGAL { get; set; }
    
        public virtual ICollection<TBL_SOLICITUDPERMISO> TBL_SOLICITUDPERMISO { get; set; }
        public virtual ICollection<TBL_PERMISOUSUARIO> TBL_PERMISOUSUARIO { get; set; }
    }
}
