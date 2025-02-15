using System;

class Program
{
    static void Main()
    {
        
        int numeroEntero;
        double numeroDecimal;
        string texto;
        bool valorBooleano;

        // aca se solicitara al usuario para que se muestre en consola. writeline
        Console.Write("ingresa un número entero: ");
        numeroEntero = int.Parse(Console.ReadLine());

        Console.Write("ingresa un número decimal: ");
        numeroDecimal = double.Parse(Console.ReadLine());

        Console.Write("Introduce un texto: ");
        texto = Console.ReadLine();

        Console.Write("ingresa un valor verdadero o falso (true/false): ");
        valorBooleano = bool.Parse(Console.ReadLine());

        // se muestran los valores que ingreso el usuario a la consola.writeline
        Console.WriteLine("\nValores ingresados:");
        Console.WriteLine($"Número entero: {numeroEntero}");
        Console.WriteLine($"Número decimal: {numeroDecimal}");
        Console.WriteLine($"Texto: {texto}");
        Console.WriteLine($"Valor verdadero o falso: {valorBooleano}");
    }
}