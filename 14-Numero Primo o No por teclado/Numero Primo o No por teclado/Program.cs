using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ingrese un número entero:");
        if (int.TryParse(Console.ReadLine(), out int numero))
        {
            if (EsPrimo(numero))
            {
                Console.WriteLine($"{numero} es un número primo.");
            }
            else
            {
                Console.WriteLine($"{numero} no es un número primo.");
            }
        }
        else
        {
            Console.WriteLine("Entrada no válida. Por favor, ingrese un número entero.");
        }
    }
    static bool EsPrimo(int numero)
    {
        if (numero <= 1) return false;
        for (int i = 2; i <= Math.Sqrt(numero); i++)
        {
            if (numero % i == 0) return false;
        }
        return true;
    }
}