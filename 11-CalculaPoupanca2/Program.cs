using System;
class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executando o projeto 11 - Calcula Poupança");

        double investimento = 1000;

        // rendimento de 0.5% (0.005) ao mês

        double rendimento = 0.005;

        for (int mes = 1; mes <= 12; mes++)
        {
            investimento = investimento + investimento * rendimento;
            Console.WriteLine("No mês " + mes + " você tem R$ " + investimento);
        }

        Console.WriteLine("Tecle enter para finalizar...");
        Console.ReadLine();
    }
}
