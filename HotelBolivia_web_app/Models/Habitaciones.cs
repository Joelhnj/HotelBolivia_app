using HotelBolivia_web_app.Dtos;
using MessagePack;
using Microsoft.EntityFrameworkCore;

namespace HotelBolivia_web_app.Models
{
    [Keyless]
    public class Habitaciones
    {

        public TipoHabitacionesEnum Tipo { get; set; }
    }
}
