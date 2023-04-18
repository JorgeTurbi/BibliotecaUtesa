using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Modelo
{
    public  class ModelEmpleado
    {

        [Key]
        public int Id { get; set; }
        public  string Cedula { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Dirección { get; set; }
        public string Teléfono { get; set; }
        public string Email { get; set; }
        public string cargo { get; set; }

     

    }
}
