using System;

class Program
{
    static void Main(string[] args)
    {
        MostrarMenu();
    }

    // Procedimiento que muestra el menú
    static void MostrarMenu()
    {
        Console.WriteLine("======================================");
        Console.WriteLine(" Bienvenido al Práctico de C#");
        Console.WriteLine("======================================");
        Console.WriteLine("Seleccione qué ejercicio desea ejecutar:");
        Console.WriteLine("5. Ejercicio 5");
        Console.WriteLine("6. Ejercicio 6");
        Console.WriteLine("7. Ejercicio 7");
        Console.WriteLine("8. Ejercicio 8");
        Console.WriteLine("9. Ejercicio 9");
        Console.WriteLine("10. Ejercicio 10");
        Console.WriteLine("11. Ejercicio 11");
        Console.WriteLine("0. Salir");
        Console.Write("Opción: ");

        int opcion = int.Parse(Console.ReadLine());

        switch (opcion)
        {
            case 5:
                Console.WriteLine("Ejecutando ejercicio 5...");
                // Llamar a una función para el ejercicio 5 (si la tenés)
                break;
            case 6:
                Console.WriteLine("Ejecutando ejercicio 6...");
                break;
            case 7:
                Console.WriteLine("Ejecutando ejercicio 7...");
                break;
            case 8:
                Console.WriteLine("Ejecutando ejercicio 8...");
                break;
            case 9:
                Console.WriteLine("Ejecutando ejercicio 9...");
                break;
            case 10:
                Console.WriteLine("Ejecutando ejercicio 10...");
                break;
            case 11:
                Console.WriteLine("Ejecutando ejercicio 11...");
                break;
            case 0:
                Console.WriteLine("Saliendo del programa...");
                break;
            default:
                Console.WriteLine("Opción no válida.");
                break;
        }
    }
}

