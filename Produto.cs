using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramaTeste
{
    public  abstract class Produto
    {
        public string Nome { get; set; }
        public double PrecoCompra { get; private set; }
        public double PrecoVenda { get; set; }

        public static double Markup { get; set; }

        public Produto(string nome, double precoCompra)
        {
            Nome = nome;
            PrecoCompra = precoCompra;
        }

        public abstract double CalculaPrecoVenda(double markup);
        

    }
}
