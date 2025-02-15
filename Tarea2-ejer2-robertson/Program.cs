using System;

namespace ProyectoConsola
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variables para el int
            int num1, num2;

            // los valores que ingrese el usuario
            Console.Write("Ingresa un número entero: ");
            num1 = int.Parse(Console.ReadLine());

            Console.Write("Ingresa el segundo número entero: ");
            num2 = int.Parse(Console.ReadLine());

            // Operacion para el int
            Console.WriteLine("\nOperaciones con int:");
            Console.WriteLine($"Suma: {num1} + {num2} = {num1 + num2}");
            Console.WriteLine($"Resta: {num1} - {num2} = {num1 - num2}");
            Console.WriteLine($"Multiplicación: {num1} * {num2} = {num1 * num2}");
            Console.WriteLine($"División: {num1} / {num2} = {num1 / num2}\n");

            
            decimal dec1, dec2;

            // aca le pido la usuario que ingre algunos valores de decimales
            Console.Write("Ingresa el primer número decimal: ");
            dec1 = decimal.Parse(Console.ReadLine());

            Console.Write("Ingresa el segundo número decimal: ");
            dec2 = decimal.Parse(Console.ReadLine());

            // Operacion con  decimales
            Console.WriteLine("\nOperaciones con decimal:");
            Console.WriteLine($"Suma: {dec1} + {dec2} = {dec1 + dec2}");
            Console.WriteLine($"Resta: {dec1} - {dec2} = {dec1 - dec2}");
            Console.WriteLine($"Multiplicación: {dec1} * {dec2} = {dec1 * dec2}");
            Console.WriteLine($"División: {dec1} / {dec2} = {dec1 / dec2}\n");

            // Variable para el  float
            float flt1, flt2;

            // que el  usuario que ingrese los valores float
            Console.Write("Ingresa el primer número float: ");
            flt1 = float.Parse(Console.ReadLine());

            Console.Write("Ingresa el segundo número float: ");
            flt2 = float.Parse(Console.ReadLine());

            // Operaciones con el float
            Console.WriteLine("\nOperaciones con float:");
            Console.WriteLine($"Suma: {flt1} + {flt2} = {flt1 + flt2}");
            Console.WriteLine($"Resta: {flt1} - {flt2} = {flt1 - flt2}");
            Console.WriteLine($"Multiplicación: {flt1} * {flt2} = {flt1 * flt2}");
            Console.WriteLine($"División: {flt1} / {flt2} = {flt1 / flt2}\n");

            // Variables de tipo int16
            short int16_1, int16_2;

            // pedir que  se ingresen los valores int16
            Console.Write("Ingresa el primer número int16: ");
            int16_1 = short.Parse(Console.ReadLine());

            Console.Write("Ingresa el segundo número int16: ");
            int16_2 = short.Parse(Console.ReadLine());

            // Operaciones con  int16
            Console.WriteLine("\nOperaciones con int16:");
            Console.WriteLine($"Suma: {int16_1} + {int16_2} = {int16_1 + int16_2}");
            Console.WriteLine($"Resta: {int16_1} - {int16_2} = {int16_1 - int16_2}");
            Console.WriteLine($"Multiplicación: {int16_1} * {int16_2} = {int16_1 * int16_2}");
            Console.WriteLine($"División: {int16_1} / {int16_2} = {int16_1 / int16_2}\n");

            // Variables con byte
            byte byte1, byte2;

            
            Console.Write("Ingresa el primer número byte: ");
            byte1 = byte.Parse(Console.ReadLine());

            Console.Write("Ingresa el segundo número byte: ");
            byte2 = byte.Parse(Console.ReadLine());

            
            Console.WriteLine("\nOperaciones con byte:");
            Console.WriteLine($"Suma: {byte1} + {byte2} = {byte1 + byte2}");
            Console.WriteLine($"Resta: {byte1} - {byte2} = {byte1 - byte2}");
            Console.WriteLine($"Multiplicación: {byte1} * {byte2} = {byte1 * byte2}");
            Console.WriteLine($"División: {byte1} / {byte2} = {byte1 / byte2}");


            Console.ReadKey();
        }
    }
}