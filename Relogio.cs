using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramaTeste
{
    public class Relogio : Produto
    {

        public Relogio(string nome, double precoCompra) : base(nome, precoCompra)
        {
            Console.WriteLine("Acionado construtor Relogio");
        }

    }
}
