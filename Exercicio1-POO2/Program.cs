using Exercicio1;

internal class Program
{
    private static void Main(string[] args)
    {
        Varejo varejo = new("Atacadão", "22.850.643/0001-67");
        varejo.ImprimirInformacoes();
        varejo.RealizarVenda();

        Console.WriteLine("");

        Empreteira empreteira = new("Construções", "41.144.532/0001-80");
        empreteira.ImprimirInformacoes();
        empreteira.RealizarVenda();

    }
}