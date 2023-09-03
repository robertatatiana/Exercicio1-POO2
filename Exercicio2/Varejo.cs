using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio2_POO2
{
    internal class Varejo : Empresa, IEmpresa
    {
        public Varejo(string nome, string cNPJ) : base(nome, cNPJ)
        {
        }

        public void ImprimirInformacoes()
        {
            Console.WriteLine("Dados da Empresa:");
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"CNPJ: {CNPJ}");
        }

        public void RealizarVenda()
        {
            Console.WriteLine("Realizando venda de produtos pela classe Varejo");
        }
    }
}
