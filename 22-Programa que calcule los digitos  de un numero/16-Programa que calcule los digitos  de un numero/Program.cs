using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ingrese un número entero:");
        string input = Console.ReadLine();
        
        if (int.TryParse(input, out int number))
        {
            int digitCount = 0;
            int temp = Math.Abs(number); 
            do
            {
                digitCount++;
                temp /= 10;
            } while (temp > 0);
            Console.WriteLine($"El número {number} tiene {digitCount} dígitos.");
        }
        else
        {
            Console.WriteLine("Entrada no válida. Por favor, ingrese un número entero.");
        }
    }
}