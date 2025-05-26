using System;

class Program

{
static void Main()
        {
        Console.WriteLine("Ingrese el primer número entero:");
        int num1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Ingrese el segundo número entero:");
        int num2 = Convert.ToInt32(Console.ReadLine());
        int suma = num1 + num2;
        Console.WriteLine($"La suma de {num1} y {num2} es: {suma}");
    }

}
    