using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese la calificación de prácticas (0-100): ");
        double pr = double.Parse(Console.ReadLine());

        Console.Write("Ingrese la calificación del examen (0-100): ");
        double ex = double.Parse(Console.ReadLine());

        Console.Write("Ingrese la calificación de tareas (0-100): ");
        double ta = double.Parse(Console.ReadLine());

        // Validar que las calificaciones estén en el rango correcto
        if (EsCalificacionValida(pr) && EsCalificacionValida(ex) && EsCalificacionValida(ta))
        {
            double calificacionFinal = CalcularCalificacion(pr, ex, ta);
            Console.WriteLine($"\nLa calificación final del alumno es: {calificacionFinal:F2}");
        }
        else
        {
            Console.WriteLine("\nError: Ingrese calificaciones entre 0 y 100.");
        }
    }

    // Método para calcular la calificación final
    static double CalcularCalificacion(double pr, double ex, double ta)
    {
        return (pr * 0.55) + (ex * 0.30) + (ta * 0.15);
    }

    // Método para validar si una calificación está en el rango de 0 a 100
    static bool EsCalificacionValida(double calificacion)
    {
        return calificacion >= 0 && calificacion <= 100;
    }
}
