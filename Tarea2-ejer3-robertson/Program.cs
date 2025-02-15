using System;

class Program
{
    static void Main()
    {
        //  valores numéricos
        Console.Write("Introduce el primer número: ");
        double numero1 = double.Parse(Console.ReadLine());

        Console.Write("Introduce el segundo número: ");
        double numero2 = double.Parse(Console.ReadLine());

        // comparaciones y operaciones lógicas
        bool esMayor = numero1 > numero2;
        bool esMenor = numero1 < numero2;
        bool esIgual = numero1 == numero2;

        bool andOperacion = (numero1 > 0) && (numero2 > 0);
        bool orOperacion = (numero1 > 0) || (numero2 > 0);

        //  resultados
        Console.WriteLine("\nResultados de las comparaciones:");
        Console.WriteLine($"{numero1} > {numero2}: {esMayor}");
        Console.WriteLine($"{numero1} < {numero2}: {esMenor}");
        Console.WriteLine($"{numero1} == {numero2}: {esIgual}");

        Console.WriteLine("\nResultados de las operaciones lógicas:");
        Console.WriteLine($"({numero1} > 0) && ({numero2} > 0): {andOperacion}");
        Console.WriteLine($"({numero1} > 0) || ({numero2} > 0): {orOperacion}");
    }
}