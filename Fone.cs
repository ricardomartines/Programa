using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramaTeste
{
    public class Fone :  Produto
    {
        public Fone(string nome, double precoCompra) : base(nome, precoCompra)
        {
            Console.WriteLine("Acionando construtor Fone");
        }

        public override double CalculaPrecoVenda(double markup)
        {
            return PrecoVenda = (PrecoCompra * markup) + 20;
        }
    }
}
