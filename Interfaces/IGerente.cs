namespace HotelCSharp.Interfaces
{
    public interface IGerente : ICamareira, IRecepcionista
    {
        void ConhecerMuitoBemOHotel();
    }
}