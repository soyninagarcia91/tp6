using System;

class Programa
{
    // Función que invierte un número entero
    static int Invertir(int numero)
    {
        int invertido = 0;
        while (numero > 0)
        {
            invertido = invertido * 10 + (numero % 10);
            numero = numero / 10;
        }
        return invertido;
    }

    static void Main(string[] args)
    {
        Console.Write("Ingrese un número entero: ");
        int numeroOriginal = int.Parse(Console.ReadLine());

        // Se obtiene el número invertido usando la función
        int numeroInvertido = Invertir(numeroOriginal);

        // Comparación para saber si es capicúa
        if (numeroOriginal == numeroInvertido)
        {
            Console.WriteLine("El número es capicúa.");
        }
        else
        {
            Console.WriteLine("El número no es capicúa.");
        }
    }
}

