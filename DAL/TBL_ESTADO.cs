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
    
    public partial class TBL_ESTADO
    {
        public TBL_ESTADO()
        {
            this.TBL_ESTADOSOLICITUDPERMISO = new HashSet<TBL_ESTADOSOLICITUDPERMISO>();
        }
    
        public decimal ID_ESTADO_SOL { get; set; }
        public string DESC_ESTADO { get; set; }
    
        public virtual ICollection<TBL_ESTADOSOLICITUDPERMISO> TBL_ESTADOSOLICITUDPERMISO { get; set; }
    }
}