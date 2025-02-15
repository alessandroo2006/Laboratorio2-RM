using System;

class Program
{
    static void Main()
    {
        
        Console.Write("Introduce la edad de la persona: ");
        int edad = int.Parse(Console.ReadLine());

        
        string categoria;

        if (edad < 12)
        {

            categoria = "Niño";
        }
        else if (edad >= 12 && edad <= 17)
        {
            categoria = "Adolescente";
        }
        else if (edad >= 18 && edad <= 59)
        {
            categoria = "Adulto";
        }
        else
        {
            categoria = "Adulto mayor";
        }

        
        Console.WriteLine($"\nLa persona con edad de {edad} años es un(@) {categoria}.");
    }
}