using System.Reflection.Metadata;

namespace ej8
//    Escribir un procedimiento Reverso que permita ingresar como parametro una cadena, y mediante un parametro por referencia devuelva la cadena invertida(“hola” 
//se convierte en “aloh”). Escribir luego un programa que determine si una cadena de caracteres es un palíndromo(un palíndromo es un texto que se lee igual en sentido
//directo y en inverso, ej.: “radar”). Sugerencia: para evitar diferencias entre mayúsculas y minúsculas en las cadenas, utilice la función del tipo string .ToUpper()
//ó.ToLower() en las cadenas, ya que si evaluamos estrictamente las cadenas Radar
//es distinto a radaR.

{
    using System;

    class Programa
    {
        // Procedimiento que invierte una cadena
        static void Reverso(string original, ref string invertida)
        {
            char[] caracteres = original.ToCharArray();
            Array.Reverse(caracteres);
            invertida = new string(caracteres);
        }

        // Función que determina si una cadena es palíndromo
        static bool EsPalindromo(string texto)
        {
            string textoProcesado = texto.ToLower();//texto.ToLower()  sirve para convertir todos los caracteres de un texto a minúsculas.
            string invertido = "";
            Reverso(textoProcesado, ref invertido);
            return textoProcesado == invertido;
        }

        static void Main()
        {
            Console.Write("Ingrese una palabra o frase: ");
            string entrada = Console.ReadLine();

            if (EsPalindromo(entrada))
                Console.WriteLine("✅ Es un palíndromo.");
            else
                Console.WriteLine("❌ No es un palíndromo.");
        }
    }
}