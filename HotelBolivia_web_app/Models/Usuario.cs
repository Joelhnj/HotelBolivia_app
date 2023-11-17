using HotelBolivia_web_app.Dtos;

namespace HotelBolivia_web_app.Models
{
    public class Usuario
    {
        public String? Email { get; set; }
        public String? Password { get; set; }
        public String? NombreCompleto { get; set; }
        public RolEnum Rol { get; set; }

    }
}
