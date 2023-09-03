using Exercicio2_POO2;

internal class Program
{
    private static void Main(string[] args)
    {
        List<IEmpresa> empresas = new List<IEmpresa>();

        Varejo varejo = new("Atacadão Do Povo", "22.850.643/0001-67");
        Empreteira empreteira = new("Construções Do Povo", "41.144.532/0001-80");

        empresas.Add(empreteira);
        empresas.Add(varejo);

        foreach(var i in  empresas) 
        {
            i.ImprimirInformacoes();
            i.RealizarVenda();
        }
    }
}