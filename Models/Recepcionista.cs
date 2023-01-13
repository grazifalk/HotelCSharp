using HotelCSharp.Interfaces;

namespace HotelCSharp.Models
{
    public class Recepcionista : Pessoa, IRecepcionista
    {
        public Recepcionista() : base()
        {
        }

        public Recepcionista(string nome, string cpf, string telefone)
        :base (nome, cpf, telefone)
        {
        }

        public void AtenderOTelefone()
        {
            Console.WriteLine("Sei atender o telefone.");
            Console.WriteLine();
        }

        public void FalarInglesBasico()
        {
            Console.WriteLine("Hello! I can speak english.");
            Console.WriteLine();
        }

        public override void SeApresentar()
        {
            Console.WriteLine("Hotel CSharp, recepcionista " + Nome);
            Console.WriteLine();
        }
    }
}