//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ACKCMS.Contenidos.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class CMS_CATEGORIA
    {
        public CMS_CATEGORIA()
        {
            this.CMS_ARTICULO = new HashSet<CMS_ARTICULO>();
        }
    
        public int ID_CATEGORIA { get; set; }
        public string Nombre { get; set; }
        public string Descripción { get; set; }
        public string UI_INFO { get; set; }
    
        public virtual ICollection<CMS_ARTICULO> CMS_ARTICULO { get; set; }
    }
}
