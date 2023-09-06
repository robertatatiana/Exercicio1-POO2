using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio3
{
    internal class Varejo : Empresa, IEmpresa
    {
        private readonly EnviarNotificacaoWhatsApp notificacaoWhatsApp;
        public Varejo(string nome, string cNPJ, EnviarNotificacaoWhatsApp notificacaoWhatsApp) : base(nome, cNPJ)
        {
            this.notificacaoWhatsApp = notificacaoWhatsApp;
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

            notificacaoWhatsApp.EnviarMensagemCliente();
        }
    }
}
