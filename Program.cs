using HotelCSharp.Models;

Console.WriteLine("******************************************");
Console.WriteLine("************** Hotel CSharp **************");
Console.WriteLine("******************************************");
Console.WriteLine();

// Contratar uma camareira:
var camareira = new Camareira("Maria Silva", "14725836987", "2298888-7777");
camareira.SeApresentar();
camareira.ArrumarACama();
camareira.LimparOQuarto();

// Contratar uma recepcionista usando object initializer:
var recepcionista = new Recepcionista()
{
    Nome = "Mariana Alves",
    CPF = "96385274165",
    Telefone = "2297777-8888"
};

recepcionista.SeApresentar();
recepcionista.AtenderOTelefone();
recepcionista.FalarInglesBasico();

//Contratar um gerente:
var gerente = new Gerente("João Santos", "85278931246", "2291111-2222");

gerente.SeApresentar();
gerente.ArrumarACama();
gerente.LimparOQuarto();
gerente.AtenderOTelefone();
gerente.FalarInglesBasico();