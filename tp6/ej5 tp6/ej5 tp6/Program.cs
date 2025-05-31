using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Ingrese un carácter: ");
        char caracter = Console.ReadKey().KeyChar;
        Console.WriteLine(); // Salto de línea

        if (Es_Digito(caracter))
        {
            Console.WriteLine("Es un dígito.");
        }
        else
        {
            Console.WriteLine("No es un dígito.");
        }
    }

    // Función lógica que devuelve true si el carácter es un dígito
    static bool Es_Digito(char c)
    {
        return char.IsDigit(c);
    }
}

