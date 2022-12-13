using System;
class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executando o projeto 13 - Encadeando for");

        for (int contadorLinhas = 0; contadorLinhas <= 9; contadorLinhas++ )
        {
            for(int contadorColunas = 0; contadorColunas  <= 9; contadorColunas++)
            {
                Console.Write("*");
                if (contadorColunas >= contadorLinhas)
                    break;
            }
            Console.WriteLine();
        }

        Console.WriteLine("Tecle enter para finalizar...");
        Console.ReadLine();
    }
}
