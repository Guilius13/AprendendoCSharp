using System;
class Programa
{
    static void Main(string[] args)
    {
        double salario = 3300.0;

        if (salario >= 1900.0 && salario <= 2800.0)
        {
            Console.WriteLine("Sua aliquota é de 7.5%");
            Console.WriteLine("Você pode deduzir até R$ 142.0");
        }else if (salario > 2800.0 && salario <= 3751.0)
        {
            Console.WriteLine("Sua aliquota é de 15%");
            Console.WriteLine("Você pode deduzir até R$ 350.0");
        }else if (salario > 3751 && salario <= 4664.0)
        {
            Console.WriteLine("Sua aliquota é de 22.5%");
            Console.WriteLine("Você pode deduzir até R$ 636.0");
        }
    }
}