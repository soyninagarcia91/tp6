//Diseñar y escribir una función de tipo double llamada RedondearCentesima que devuelva un numero double redondeado a dos posiciones decimales. Usarla en un programa o procedimiento que la invoque. 
//Por ejemplo: RedondearCentesima(1.236589) debe devolver 1.24 mientras que RedondearCentesima(1.9238) debe devolver 1.92 Sugerencia: utilizar multiplicaciones, módulo y divisiones para obtener el resultado.

using System;

class Programa
{
    // Función que redondea un número a dos decimales sin usar Math.Round
    static double RedondearCentesima(double numero)
    {
        numero = numero * 100;          // Mover dos decimales
        numero = (int)(numero + 0.5);   // Redondeo manual clásico
        return numero / 100.0;          // Volver al formato con dos decimales
    }

    static void Main()
    {
        Console.WriteLine("Ejemplo 1: " + RedondearCentesima(1.236589));  // 1.24
        Console.WriteLine("Ejemplo 2: " + RedondearCentesima(1.9238));    // 1.92
        Console.WriteLine("Ejemplo 3: " + RedondearCentesima(9.99999));   // 10.00
        Console.WriteLine("Ejemplo 4: " + RedondearCentesima(3.005));     // 3.01
    }
}
