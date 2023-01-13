using HotelCSharp.Interfaces;

namespace HotelCSharp.Models
{
    public class Hotel
    {
        public string Nome { get; set; }

        public Endereco Endereco { get; set; }

        public List<IRecepcionista> Recepcionistas {get; set; }

        public List<ICamareira> Camareiras {get; set; }

        public IGerente Gerente { get; set; }

    }
}