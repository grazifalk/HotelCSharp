using HotelCSharp.Exceptions;
using HotelCSharp.Interfaces;
using HotelCSharp.Models;

Console.WriteLine("******************************************");
Console.WriteLine("************* Hotel da Grazi *************");
Console.WriteLine("******************************************");
Console.WriteLine();

// Contratar uma camareira:
// var camareira = new Camareira("Maria Silva", "14725836987", "2298888-7777");
// camareira.SeApresentar();
// camareira.ArrumarACama();
// camareira.LimparOQuarto();

// Contratar uma recepcionista usando object initializer:
// var recepcionista = new Recepcionista()
// {
//     Nome = "Mariana Alves",
//     CPF = "96385274165",
//     Telefone = "2297777-8888"
// };

// recepcionista.SeApresentar();
// recepcionista.AtenderOTelefone();
// recepcionista.FalarInglesBasico();

//Contratar um gerente:
// var gerente = new Gerente("João Santos", "85278931246", "2291111-2222");

// gerente.SeApresentar();
// gerente.ArrumarACama();
// gerente.LimparOQuarto();
// gerente.AtenderOTelefone();
// gerente.FalarInglesBasico();

ICamareira camareira1 = new Camareira("Joana Silva", "14725836987", "2298888-7777");
ICamareira camareira2 = new Camareira("Maria Silva", "85246127935", "2298888-7776");

IRecepcionista recepcionista1 = new Recepcionista()
{
    Nome = "Mariana Alves",
    CPF = "96385274165",
    Telefone = "2297777-8888"
};

IRecepcionista recepcionista2 = new Recepcionista("Jessica Andrade", "85265432198", "2198888-5555");

IGerente gerente1 = new Gerente("João Santos", "85278931246", "2291111-2222");

IGerente gerente2 = new Gerente("Marcos Araújo", "96325874154", "22933333-7777");

// Inauguração do Hotel
Hotel hotel = new Hotel("Hotel da Grazi", new Endereco()
{
    CEP = "28630-000",
    Rua = "Rua das Pedras, ",
    Numero = 28,
    Complemento = "lagoa",
    Bairro = "Centro",
    Cidade = "Nova Friburgo",
    Estado = "RJ"
});

//Contratando Camareiras
hotel.ContratarCamareira(camareira1);
hotel.ContratarCamareira(camareira2);

//Contratando Recepcionistas
hotel.ContratarRecepcionista(recepcionista1);
hotel.ContratarRecepcionista(recepcionista2);

//Contratando Gerente
hotel.ContratarGerente(gerente1);

//Contratando Gerente para outra função - ex: folguista/substituto - faz tudo
hotel.ContratarRecepcionista(gerente2);
hotel.ContratarCamareira(gerente2);

//Apresentação dos Funcionários
hotel.Gerente.SeApresentar();
hotel.Gerente.ArrumarACama();
hotel.Gerente.LimparOQuarto();
hotel.Gerente.AtenderOTelefone();
hotel.Gerente.FalarInglesBasico();

foreach (var camareira in hotel.Camareiras)
{
    camareira.SeApresentar();
    camareira.ArrumarACama();
    camareira.LimparOQuarto();
}

foreach (var recepcionista in hotel.Recepcionistas)
{
    recepcionista.SeApresentar();
    recepcionista.AtenderOTelefone();
    recepcionista.FalarInglesBasico();
}

//RH em atividade:

IRHTerceirizado rh = new RH("RH CSharp", hotel);

//Contratar uma camareira
var camareira3 = new Camareira
{
    Nome = "Luciana Ferraz"
};

rh.ContratarCamareira(camareira3);

//Contratar uma recepcionista
var recepcionista3 = new Recepcionista("Joice Lima", "12312352858", "2295555-6666");

rh.ContratarRecepcionista(recepcionista3);

//Provover uma camareira
var camareiraASerPromovida = new Camareira
{
    Nome = "Eugenia Lima"
};

try
{
    rh.PromoverParaGerente(camareiraASerPromovida);
}
catch (DocumentosInvalidosException ex)
{
    //se cair aqui, foi erro de documentação.
    System.Console.WriteLine(ex.Message);
}
catch (Exception ex)
{
    System.Console.WriteLine(ex.Message);
}



//Promover uma recepcionista

var recepcionistaASerPromovida = new Recepcionista
{
    Nome = "Amanda Vasconcelos",
    CPF = "96585474556"
};

try
{
    rh.PromoverParaGerente(recepcionistaASerPromovida);
}
catch (DocumentosInvalidosException ex)
{
    //se cair aqui, foi erro de documentação.
    System.Console.WriteLine(ex.Message);
}
catch (Exception ex)
{
    //se cair aqui, é problema no sistema.
    Console.WriteLine(ex.Message);
}

Console.WriteLine();