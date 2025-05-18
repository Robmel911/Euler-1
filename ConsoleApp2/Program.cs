using System;
class Program
{
    static void Main(string[] args)
    {
        int x = 0; int p;
        Console.WriteLine("Ingrese el intervalo");
        p = int.Parse(Console.ReadLine());
        int c = p - 1;
        for (int i=0; i<=c; ++i)
        {
            if (i % 3 == 0 || i % 5 == 0)
            {
                x = i + x;
            }
        }
        Console.WriteLine("La suma de los multiplos de 3 y 5 es: " + x);
    }
}