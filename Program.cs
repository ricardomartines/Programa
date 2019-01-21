using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramaTeste
{
    class Program
    {
        static void Main(string[] args)
        {

            GeraPrecoVenda();

            /*
            Console.WriteLine("Programa Teste !");

            Produto produto = new Produto("Mi band 3", 100);

            Console.WriteLine("Preço de compra do produto mi band 3 é: " + produto.PrecoCompra);

            produto.CalculaPrecoVenda(0.5);

            Console.WriteLine("Preço de venda é: " + produto.PrecoVenda);


            Relogio relogio = new Relogio("Zeblaze", 280);

            Console.WriteLine("Preço de compra do relogio zeblaze é: " + relogio.PrecoCompra);
           
            relogio.CalculaPrecoVenda(0.7);

            Console.WriteLine("Preço de venda é: " + relogio.PrecoVenda);
            */
        }

        public static void GeraPrecoVenda()
        {
            Pulseira pulseira = new Pulseira("Mi Band 3", 100);
            pulseira.CalculaPrecoVenda(1.40);
            Console.WriteLine("Preço de venda pulseira: " + pulseira.PrecoVenda);

            Relogio relogio = new Relogio("Zeblaze Thor 4", 400);
            relogio.CalculaPrecoVenda(1.50);
            Console.WriteLine("Preço de venda relógio: " + relogio.PrecoVenda);

            Fone fone = new Fone("Qcy Q29", 80);
            fone.CalculaPrecoVenda(1.60);
            Console.WriteLine("Preço de venda fone: " + fone.PrecoVenda);

        }
    }
}
