using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio3
{
    internal class Empresa
    {
        public Empresa(string nome, string cNPJ)
        {
            Nome = nome;
            CNPJ = cNPJ;
        }

        public string Nome { get; set; }
        public string CNPJ { get; set; }
    }
}
