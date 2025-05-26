using System;

class Program // Cambiado de 'program' a 'Program'
{
    static void Main(string[] args)
    {
        Console.Write("Introduce tu nombre: ");
        string nombre = Console.ReadLine();
        Console.Write("Introduce tu edad: ");
        int edad;
        while (!int.TryParse(Console.ReadLine(), out edad) || edad < 0)
        {
            Console.WriteLine("Por favor, introduce una edad válida.");
        }
        if (edad >= 18)
        {
            Console.WriteLine($"Hola {nombre}, eres un adulto.");
        }
        else
        {
            Console.WriteLine($"Hola {nombre}, eres un menor.");
        }
    }
}