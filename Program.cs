using System;

namespace ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Hacer un programa que solicite 10  números enteros y los guarde en un vector. Luego recorrer ese vector para calcular el promedio. Mostrar por pantalla los valores que son mayores al promedio.*/

            int n, acu = 0, prom;
            int [] numeroh = new int [10];

            for (int x = 0; x < 10; x++)
            {
                Console.WriteLine("Por favor ingrese un número: ");
                n = int.Parse(Console.ReadLine());
                numeroh[x] = n;
                acu += numeroh[x];
            }

            prom = acu / 10;

            Console.WriteLine("prom = " + prom);

            for (int y = 0; y < 10; y++)
            {
                if (numeroh[y] > prom){
                    Console.WriteLine(numeroh[y]);
                }
            }
        }
    }
}
