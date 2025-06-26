// See https://aka.ms/new-console-template for more information

using trilha_net_poo_desafio.Models;

Nokia nokia = new Nokia("123456", "xpto", "asdf123456", "64GB");
Console.WriteLine("----------------------------------------------");
Console.WriteLine($"Apresentação do Aparelho Nokia {nokia.Modelo}");
Console.WriteLine("----------------------------------------------");
nokia.ApresentarDispositivo();
Console.WriteLine("----------------------------------------------");
Console.WriteLine("Testando o aparelho");
Console.WriteLine("----------------------------------------------");
nokia.Ligar();
nokia.Receberligacao();
Console.WriteLine("----------------------------------------------");
Console.WriteLine("Teste de instalação do aplicativo");
Console.WriteLine("----------------------------------------------");
nokia.InstalarAplicativo("DuoLingo");
Console.WriteLine("----------------------------------------------");
Console.WriteLine(" ");
Console.WriteLine(" ");
Console.WriteLine("----------------------------------------------");
Iphone iphone = new Iphone("654123", "Iphone 16", "paskd12548", "120 GB");
Console.WriteLine("----------------------------------------------");
Console.WriteLine("----------------------------------------------");
Console.WriteLine($"Apresentação do Aparelho Nokia {iphone.Modelo}");
Console.WriteLine("----------------------------------------------");
iphone.ApresentarDispositivo();
Console.WriteLine("----------------------------------------------");
Console.WriteLine("Testando o aparelho");
Console.WriteLine("----------------------------------------------");
iphone.Ligar();
iphone.Receberligacao();
Console.WriteLine("----------------------------------------------");
Console.WriteLine("Teste de instalação do aplicativo");
Console.WriteLine("----------------------------------------------");
iphone.InstalarAplicativo("Instagram");
Console.WriteLine("----------------------------------------------");