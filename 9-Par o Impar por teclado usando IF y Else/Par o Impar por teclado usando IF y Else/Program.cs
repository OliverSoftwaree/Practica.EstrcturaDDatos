﻿using System;
class program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Introduce un número:");
        int numero = Convert.ToInt32(Console.ReadLine());
        if (numero % 2 == 0)
        {
            Console.WriteLine("El número es par.");
        }
        else
        {
            Console.WriteLine("El número es impar.");
        }
    }
}