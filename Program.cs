using System.Globalization;
using Infertaces.entidades;
using Infertaces.Serviços;
using System.Security.Cryptography;



Console.WriteLine("Entre Com os dados do alugel :");
Console.WriteLine("Digite o modelo do carro");
string modelo = Console.ReadLine();
Console.WriteLine("Digite a data de Incio(dd/MM/yyyy hh:mm)");
DateTime Inicio = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
Console.WriteLine("Digite a data de entrega (dd/MM/yyyy hh:mm)");
DateTime Retorno = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);

Console.WriteLine("Digite o Preço por Hora");
double Hora = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
Console.WriteLine("Digite o Preço por Dia");
double Dia = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

AluguelCarros alug = new AluguelCarros(Inicio,Retorno, new Veiculos(modelo));
NotasAluguel Nota = new NotasAluguel(Hora,Dia, new Imposto());
Nota.ProcessoInVoice(alug);
Console.WriteLine("INVOICE");
Console.WriteLine(alug.inVoice);

