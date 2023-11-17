using HotelBolivia_web_app.Dtos;

namespace HotelBolivia_web_app.Models
{
    public class PagoAlquiler
    {
        public int Codigo { get; set; }
        public int Dias { get; set; }
        public DateTime Fecha { get; set; }
        public float MontoPago { get; set; }
        public int Numero { get; set; }
       public int NumFactura { get; set; } 
    }
}
