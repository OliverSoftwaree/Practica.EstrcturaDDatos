using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ingrese un número entero:");
        string input = Console.ReadLine();
        
        if (IsCapicua(input))
        {
            Console.WriteLine("El número es capicúa.");
        }
        else
        {
            Console.WriteLine("El número no es capicúa.");
        }
    }
    static bool IsCapicua(string number)
    {
    
        string cleanedNumber = number.Replace(" ", "").ToLower();
        
        char[] charArray = cleanedNumber.ToCharArray();
        Array.Reverse(charArray);
        string reversedNumber = new string(charArray);
        
        return cleanedNumber == reversedNumber;
    }
}

