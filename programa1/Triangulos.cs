using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            // Solicitar los tres lados del triángulo
            Console.Write("Ingrese el primer lado (a): ");
            double a = double.Parse(Console.ReadLine());

            Console.Write("Ingrese el segundo lado (b): ");
            double b = double.Parse(Console.ReadLine());

            Console.Write("Ingrese el tercer lado (c): ");
            double c = double.Parse(Console.ReadLine());

            // Terminar si los tres lados son 0
            if (a == 0 && b == 0 && c == 0)
                break;

            // Verificar que los lados formen un triángulo válido
            if (a + b > c && a + c > b && b + c > a)
            {
                // Calcular el semi-perímetro
                double p = (a + b + c) / 2;

                // Aplicar la fórmula de Herón para el área
                double area = Math.Sqrt(p * (p - a) * (p - b) * (p - c));

                // Mostrar el área calculada
                Console.WriteLine($"El área del triángulo es: {area:F2}");

                // Determinar el tipo de triángulo
                if (a == b && b == c)
                {
                    Console.WriteLine("El triángulo es Equilátero.");
                }
                else if (a == b || b == c || a == c)
                {
                    Console.WriteLine("El triángulo es Isósceles.");
                }
                else
                {
                    Console.WriteLine("El triángulo es Escaleno.");
                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Los valores ingresados no forman un triángulo válido. Intente nuevamente.\n");
            }
        }

        Console.WriteLine("Fin del programa.");
    }
}
