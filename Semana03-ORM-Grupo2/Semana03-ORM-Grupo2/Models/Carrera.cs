using System.ComponentModel.DataAnnotations;

namespace Semana03_ORM_Grupo2.Models
{
    public class Carrera
    {
        [Key]
        public int Id { get; set; }
        public string Nombre { get; set; }
    }
}
