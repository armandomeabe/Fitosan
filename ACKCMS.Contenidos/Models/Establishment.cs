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
    
    public partial class Establishment
    {
        public Establishment()
        {
            this.Authors = new HashSet<Author>();
        }
    
        public int id { get; set; }
        public string Nombre { get; set; }
        public int IdWork { get; set; }
        public int Number { get; set; }
    
        public virtual ICollection<Author> Authors { get; set; }
        public virtual Work Work { get; set; }
    }
}
