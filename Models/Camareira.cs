using HotelCSharp.Interfaces;

namespace HotelCSharp.Models
{
    public class Camareira : Pessoa, ICamareira
    {
        public Camareira() : base()
        {
        }

        public Camareira(string nome, string cpf, string telefone)
        :base (nome, cpf, telefone)
        {
        }

        public void ArrumarACama()
        {
            Console.WriteLine("Sei arrumar a cama!");
            Console.WriteLine();
        }

        public void LimparOQuarto()
        {
            Console.WriteLine("Sei limpar o quarto!");
            Console.WriteLine();
        }

        public override void SeApresentar()
        {
            Console.WriteLine("Prazer! Sou a camareira, " + Nome);
            Console.WriteLine();
        }
    }
}