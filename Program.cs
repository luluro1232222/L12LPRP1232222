using System;

class Program
{
    static void Main()
    {
        int[] puntos = new int[14];

        for (int i = 0; i < 14; i++)
        {
            Console.WriteLine("Ingrese nota ");
            puntos[i] = Convert.ToInt16(Console.ReadLine());
        }

        double promedio = 0;
        double suma = 0;
        for (int i = 0; i < 14; i++)
        {
            suma = suma + puntos[i];
        }

        promedio = suma / 14;
        Console.WriteLine("El promedio es " + promedio);
    }
}
