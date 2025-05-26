using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ingrese un número entero positivo:");
        string input = Console.ReadLine();
        
        if (int.TryParse(input, out int number) && number >= 0)
        {
            int sum = 0;
            while (number > 0)
            {
                sum += number % 10; 
                number /= 10;       
            }
            Console.WriteLine($"La suma de los dígitos es: {sum}");
        }
        else
        {
            Console.WriteLine("Por favor, ingrese un número entero positivo válido.");
        }
    }
}