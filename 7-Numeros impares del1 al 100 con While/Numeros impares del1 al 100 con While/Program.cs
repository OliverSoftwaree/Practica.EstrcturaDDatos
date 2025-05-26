using System;

class program
{
    static void Main(string[] args)
    {
        int numero = 1;
        while (numero <= 100)
        {
            if (numero % 2 != 0)
            {
                Console.WriteLine(numero);
            }
            numero++;
        }
    }
}