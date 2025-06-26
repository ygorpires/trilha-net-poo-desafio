using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace trilha_net_poo_desafio.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        public string Modelo { get; set; }
        public string IMEI { get; set; }
        public string Memoria { get; set; }

        public Smartphone(string numero, string modelo, string imei, string memoria)
        {
            Numero = numero;
            Modelo = modelo;
            IMEI = imei;
            Memoria = memoria;
        }

        public void ApresentarDispositivo()
        {
            Console.WriteLine($"Número: {Numero}");
            Console.WriteLine($"Modelo: {Modelo}");
            Console.WriteLine($"IMEi: {IMEI}");
            Console.WriteLine($"Memória: {Memoria}");
        }

        public void Ligar()
        {
            Console.WriteLine("Ligando ...");
            Console.WriteLine($"Ligaçao efetuada peo número {Numero}");
        }
        public void Receberligacao()
        {
            Console.WriteLine("Recebendo uma ligação ...");
        }

        public abstract void InstalarAplicativo(string nomeApp);

    }
}