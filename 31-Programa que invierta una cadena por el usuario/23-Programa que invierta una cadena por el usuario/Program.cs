using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ingrese una cadena de texto:");
        string input = Console.ReadLine();
        
        if (input != null)
        {
            char[] charArray = input.ToCharArray();
            Array.Reverse(charArray);
            string reversedString = new string(charArray);
            
            Console.WriteLine("Cadena invertida: " + reversedString);
        }
        else
        {
            Console.WriteLine("No se ingresó ninguna cadena.");
        }
    }
}