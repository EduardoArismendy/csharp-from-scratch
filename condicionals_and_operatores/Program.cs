using System;

class Program
{
    static void Main()
    {
        /*Conditionals*/
        Console.WriteLine("Ingrese un número:");
        int num = int.Parse(Console.ReadLine());

        Console.WriteLine(
            num > 0 ? "Positivo" :
            num < 0 ? "Negativo" :
            "Es cero"
        );
        /*End Conditionals*/

        /*Operators*/
        Console.WriteLine("Ingrese el primer número:");
        double a = double.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese el segundo número:");
        double b = double.Parse(Console.ReadLine());

        string indefinido = "Indeterminado";

        Console.WriteLine(
            $"Suma: {a + b}, " +
            $"Resta: {a - b}, " +
            $"Multiplicación: {a * b}, " +
            $"División: {(b != 0 ? (a / b).ToString() : indefinido)}"
        );
        /*End Operators*/
    }
}
