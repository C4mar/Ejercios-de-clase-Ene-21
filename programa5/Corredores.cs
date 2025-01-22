using System;

class Program
{
    static void Main()
    {
        const double DISTANCIA = 1500;  // Distancia de la carrera en metros
        int minutos, segundos;

        Console.WriteLine("Ingrese el tiempo de los corredores en formato (minutos segundos), use '0 0' para finalizar:");

        while (true)
        {
            Console.Write("Minutos: ");
            minutos = int.Parse(Console.ReadLine());

            Console.Write("Segundos: ");
            segundos = int.Parse(Console.ReadLine());

            if (minutos == 0 && segundos == 0)
                break;  // Salir del bucle si se ingresa (0,0)

            int tiempoTotalSegundos = (minutos * 60) + segundos;
            double velocidad = DISTANCIA / tiempoTotalSegundos;

            Console.WriteLine($"Tiempo: {minutos} min {segundos} seg → Velocidad: {velocidad:F2} m/s\n");
        }

        Console.WriteLine("Fin del programa.");
    }
}
