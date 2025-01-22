using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese un número entero: ");
        int numero;

        // Validar que el usuario ingrese un número entero válido
        if (int.TryParse(Console.ReadLine(), out numero))
        {
            int resultado = numero * 2;
            Console.WriteLine($"El resultado de multiplicar {numero} por 2 es: {resultado}");
        }
        else
        {
            Console.WriteLine("Error: Ingrese un número entero válido.");
        }
    }
}
