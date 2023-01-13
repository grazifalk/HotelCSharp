using HotelCSharp.Interfaces;

namespace HotelCSharp.Models
{
    public class Gerente : Pessoa, IGerente
    {
        public Gerente() : base()
        {
        }

        public Gerente(string nome, string cpf, string telefone)
        :base (nome, cpf, telefone)
        {
        }

        public void ConhecerMuitoBemOHotel()
        {
            Console.WriteLine("Sou o gerente e conheço muito bem o hotel!");
            Console.WriteLine();  
        }

        public void ArrumarACama()
        {
            Console.WriteLine("Sou o gerente e sei arrumar a cama!");
            Console.WriteLine();
        }

        public void AtenderOTelefone()
        {
            Console.WriteLine("Sou o gerente e sei atender o telefone!");
            Console.WriteLine();
        }

        public void FalarInglesBasico()
        {
            Console.WriteLine("Sou o gerente e domino inglês.");
            Console.WriteLine();
        }

        public void LimparOQuarto()
        {
            Console.WriteLine("Sou o gerente e sei limpar o quarto!");
            Console.WriteLine();
        }

        public override void SeApresentar()
        {
            Console.WriteLine("Olá, eu sou o gerente " + Nome);
            Console.WriteLine();
        }
    }
}