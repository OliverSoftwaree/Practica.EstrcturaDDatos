using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ingrese un numero para calcular su factorial: ");
        int numero = Convert.ToInt32(Console.ReadLine());
        int factorial = 1;
        for (int i = 1; i <= numero; i++)
        {
            factorial *= i;
        }
        Console.WriteLine($"El factorial de {numero} es: {factorial}");
    }
}