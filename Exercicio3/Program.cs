using Exercicio3;

internal class Program
{
    private static void Main(string[] args)
    {
        List<IEmpresa> empresas = new List<IEmpresa>();

        EnviarNotificacaoWhatsApp whatsappNotificacao = new EnviarNotificacaoWhatsApp();
        Varejo varejo = new("Atacadão Do Povo", "22.850.643/0001-67", whatsappNotificacao);
        Empreteira empreteira = new("Construções Do Povo", "41.144.532/0001-80");

        empresas.Add(empreteira);
        empresas.Add(varejo);

        foreach (var i in empresas)
        {
            i.ImprimirInformacoes();
            i.RealizarVenda();
        }
    }
}