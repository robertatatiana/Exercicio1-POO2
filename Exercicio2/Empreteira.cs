using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio2
{
    internal class Empreteira : Empresa, IEmpresa
    {
        public Empreteira(string nome, string cNPJ) : base(nome, cNPJ)
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
            Console.WriteLine("Realizando venda de serviços pela classe Empreteira");
        }
    }
}
