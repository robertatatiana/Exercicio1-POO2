using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1
{
    internal class Varejo : Empresa
    {
        public Varejo(string nome, string cNPJ) : base(nome, cNPJ)
        {
        }

        public override void RealizarVenda()
        {
            Console.WriteLine("Realizando venda de produtos pela classe Varejo");
        }
    }
}
