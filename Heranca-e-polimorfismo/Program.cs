using HerancaProj;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {

        Utilitario util = new Utilitario();
        util.marca = "Audi";
        util.valor = 10000.00;
        util.modelo = "Pequeno";
        util.quantidadelugares = 6;
        util.cor = "Preto";

        Trabalho trab = new Trabalho();
        trab.marca = "Chevrolet";
        trab.valor = 1000000.00;
        trab.modelo = "Grande";
        trab.capacidadepeso = 50000.0;
        trab.quantidadeeixos = 2;

        Console.WriteLine("A marca do veiculo é " + util.marca + " o valor é " + util.valor + " o modelo é " + util.modelo);
        Console.WriteLine("\n A quantidade de lugares é " + util.quantidadelugares + " a cor é " + util.cor);
        Console.WriteLine("\n O valor com Desconto é " + util.Desconto());

        Console.WriteLine("--------------------------------------------------\n");

        Console.WriteLine("A marca do veiculo é " + trab.marca + " o valor é " + trab.valor + " o modelo é " + trab.modelo);
        Console.WriteLine("\n A capacidade de peso é " + trab.capacidadepeso+ " a quantidade de eixos é " + trab.quantidadeeixos);
        Console.WriteLine("\n O valor com Desconto é " + trab.Desconto());

    }
}