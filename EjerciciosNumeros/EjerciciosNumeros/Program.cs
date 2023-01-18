using System;
namespace EjerciciosNumeros
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion = 0;
            bool salida = false;
            do
            {
                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("Introduce un número para comprobar si es primo");
                        while (!Int32.TryParse(Console.ReadLine(), out int num))
                        {
                            Console.WriteLine("Error, el número debe ser entero");
                        }

                        break;
                }
            } while (!salida);
        }
    }
}