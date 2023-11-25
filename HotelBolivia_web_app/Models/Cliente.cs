using HotelBolivia_web_app.Dtos;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace HotelBolivia_web_app.Models
{
    public class Cliente
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int Ci { get; set; }
        [Required]

        public String? NombreCompleto { get; set; }
        public DateTime FechaRegistro { get; set; }

        public decimal Monto { get; set; }
        public string? Foto { get; set; }
        [Required]
        public TipoHabitacionesEnum Habitaciones { get; set; }

        [NotMapped]
        [Display(Name = "Cargar Foto")]
        public IFormFile? FormFile { get; set; }
    }
}
