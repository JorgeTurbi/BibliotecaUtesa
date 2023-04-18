using System.ComponentModel.DataAnnotations;

namespace Biblioteca.Modelo
{
    public class ModeloEstudiante
    {
        [Key]
        public int Id { get; set; }
        public string Matricula { get; set; }
        public string Carrera { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Telefono { get; set; }
        public string Email_Estudiante { get; set; }

     
    }
}
