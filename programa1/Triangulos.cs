using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese la cantidad de triángulos a calcular: ");
        int cantidad = int.Parse(Console.ReadLine());

        for (int i = 1; i <= cantidad; i++)
        {
            Console.WriteLine($"\nTriángulo {i}:");
            
            Console.Write("Ingrese el lado a: ");
            double a = double.Parse(Console.ReadLine());

            Console.Write("Ingrese el lado b: ");
            double b = double.Parse(Console.ReadLine());

            Console.Write("Ingrese el lado c: ");
            double c = double.Parse(Console.ReadLine());

            if (EsTrianguloValido(a, b, c))
            {
                double area = CalcularArea(a, b, c);
                Console.WriteLine($"El área del triángulo {i} es: {area:F2}");
            }
            else
            {
                Console.WriteLine("Los lados ingresados no forman un triángulo válido.");
            }
        }
    }

    // Método para calcular el área usando la fórmula de Herón
    static double CalcularArea(double a, double b, double c)
    {
        double p = (a + b + c) / 2;
        return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
    }

    // Método para verificar si los lados forman un triángulo válido
    static bool EsTrianguloValido(double a, double b, double c)
    {
        return (a + b > c) && (a + c > b) && (b + c > a);
    }
}
