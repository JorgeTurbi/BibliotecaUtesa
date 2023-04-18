using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Modelo
{
    public  class ModeloLibro
    {
        [Key]
        public int Id { get; set; }
        public string Codigo { get; set; }
        public string Autor { get; set; }
        public string Titulo { get; set; }
        public string Descripcion { get; set; }
        public string Edicion { get; set; }

      
    }
}
