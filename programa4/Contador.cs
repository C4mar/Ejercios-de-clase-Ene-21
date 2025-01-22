using System;

class Program
{
    static void Main()
    {
        int contador = 0;
        int numero;

        Console.WriteLine("Ingrese números enteros (0 para terminar):");

        do
        {
            numero = int.Parse(Console.ReadLine());

            if (numero != 0)
            {
                Console.WriteLine($"Número ingresado: {numero}");
                contador++;
            }

        } while (numero != 0);

        Console.WriteLine($"\nCantidad de valores leídos: {contador}");
    }
}
