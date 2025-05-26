using System;
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Ingrese un número: ");
        if (int.TryParse(Console.ReadLine(), out int numero))
        {
            if (EsNumeroPerfecto(numero))
            {
                Console.WriteLine($"{numero} es un número perfecto.");
            }
            else
            {
                Console.WriteLine($"{numero} no es un número perfecto.");
            }
        }
        else
        {
            Console.WriteLine("Entrada no válida. Por favor, ingrese un número entero.");
        }
    }
    static bool EsNumeroPerfecto(int numero)
    {
        int sumaDivisores = 0;
        for (int i = 1; i < numero; i++)
        {
            if (numero % i == 0)
            {
                sumaDivisores += i;
            }
        }
        return sumaDivisores == numero;
    }
}