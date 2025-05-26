using System;

Console.WriteLine("Ingrese el primer número entero:");
int numero1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Ingrese el segundo número entero:");
int numero2 = Convert.ToInt32(Console.ReadLine());

int Resta = numero1 - numero2;
Console.WriteLine($"El resultado de {numero1} y {numero2} es: {Resta}");
