//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Datos
{
    using System;
    using System.Collections.Generic;
    
    public partial class Libro
    {
        public int LibroId { get; set; }
        public int AutorId { get; set; }
        public int EditorialId { get; set; }
        public string Titulo { get; set; }
        public string Genero { get; set; }
        public int NroPaginas { get; set; }
        public bool Eliminado { get; set; }
    
        public virtual Autor Autor { get; set; }
        public virtual Editorial Editorial { get; set; }
    }
}
