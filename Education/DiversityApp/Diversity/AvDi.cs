//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Diversity
{
    using System;
    using System.Collections.Generic;

    public partial class AvDi
    {
        public AvDi()
        {


        }
        public int idAvDi { get; set; }
        public Nullable<int> idDi { get; set; }
        public string username { get; set; }
    
        public virtual Avatar Avatar { get; set; }
        public virtual DisabilityType DisabilityType { get; set; }

        public AvDi(int idDi, string username)
        {
            this.idDi = idDi;
            this.username = username;
            
        }

        public AvDi(int idAvDI, int idDi, string username)
        {
            this.idAvDi = idAvDi;
            this.idDi = idDi;
            this.username = username;

        }
    }
}
