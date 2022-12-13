using System;
class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Praticando com for");


        //Imprimir múltiplos de 3 entre 1 e 100
        // versão 1
        for (int numero = 1; numero <= 100; numero++)
        {
            if (numero % 3 == 0)
            {
                Console.WriteLine(numero);
            }
        }

        // versão 2
        for (int numero = 3; numero <= 100; numero += 3)
        {
            Console.WriteLine(numero);
        }


        // imprimir os fatoriais de 1 a 10
        int fatorial = 1;

        for (int n = 1; n <= 10; n++)
        {
            fatorial *= n;
            Console.WriteLine(fatorial);
        }

        Console.WriteLine("Tecle enter para finalizar...");
        Console.ReadLine();
    }
}
