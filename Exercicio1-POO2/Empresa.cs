using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1_POO2
{
    internal abstract class Empresa
    {
        public Empresa(string nome, string cNPJ)
        {
            Nome = nome;
            CNPJ = cNPJ;
        }

        public string Nome { get; set; }
        public string CNPJ { get; set; }

        public void ImprimirInformacoes()
        {
            Console.WriteLine("Dados da Empresa:");
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"CNPJ: {CNPJ}");
        }

        public abstract void RealizarVenda();
    }
}
