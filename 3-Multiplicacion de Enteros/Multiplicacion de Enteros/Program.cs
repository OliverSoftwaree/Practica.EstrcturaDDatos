﻿using System;

{
}
Console.WriteLine("Multiplicación de enteros");
    Console.Write("Ingrese el primer número: ");
    int num1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Ingrese el segundo número: ");
    int num2 = Convert.ToInt32(Console.ReadLine());
    
    int resultado = num1 * num2;
    
    Console.WriteLine($"El resultado de {num1} * {num2} es: {resultado}");
