using HotelBolivia_web_app.Dtos;

namespace HotelBolivia_web_app.Models
{
    public class Cliente
    {
        public int Ci { get; set; }
      
        public String? NombreCompleto { get; set; }
        public TipoHabitacionesEnum Habitaciones { get; set; }
    }
}
