using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace String
{
    class MainClass
    {

        public static void Main(string[] args)
        {
            string entrada;
            int nOpcion = 0;
            int tamaño = 0;
            int introducir = 0;
            bool comprobacion = true;
            while (comprobacion)
            {
                Console.WriteLine("Elige una de las siguientes opciones:");
                Console.WriteLine("        1 palíndromo\r\n        2 mayusculas y minusculas\r\n        3 número de ocurrencias\r\n        4 Palabras repetidas\r\n        5  repetir ocurrencia\r\n        6 borrar");
                entrada = Console.ReadLine();
                if (!int.TryParse(entrada, out nOpcion))
                {
                    Console.WriteLine("Ha Introducido un formato incorrecto");
                }
                else
                {
                    if (nOpcion == 1 || nOpcion == 2 || nOpcion == 3 || nOpcion == 4 || nOpcion == 5 || nOpcion == 6)
                    {
                        comprobacion = false;
                    }
                    else
                    {
                        Console.WriteLine("El numero introducido no es una opcion del menú");
                    }
                }
            }
            if (nOpcion == 1)
            {
                string? datoEntrada;
                string? guardado = "";
                Console.WriteLine("Inserte un palíndromo");
                datoEntrada = Console.ReadLine();
                for (int i = datoEntrada.Length - 1; i >= 0; i--)
                {
                    guardado = guardado + datoEntrada[i];
                }
                if (guardado == datoEntrada)
                {
                    Console.WriteLine("felicidades es un palíndromo");
                }
                else
                {
                    Console.WriteLine("No es palíndromo");

                }
            }

            if (nOpcion == 2)
            {
                string datoEntrada;
                string mayusculas;
                string minusculas;
                Console.WriteLine("Inserte una palabra");
                datoEntrada = Console.ReadLine();
                mayusculas = datoEntrada.ToUpper();
                minusculas = datoEntrada.ToLower();
                Console.WriteLine(datoEntrada + " en minusculas es " + minusculas + " y en mayusculas "+ mayusculas);
            }

            if (nOpcion == 3)
            {
                string? datoEntrada;
                char buscador;
                string convertir;
                int contador = 0;
                Console.WriteLine("Inserte una frase");
                datoEntrada = Console.ReadLine();
                Console.WriteLine("Introduce un caracter");
                convertir = Console.ReadLine();
                if (!char.TryParse(convertir, out buscador))
                {

                }
                else
                {
                    for (int i = 0; i < datoEntrada.Length; i++)
                    {
                        if (datoEntrada[i] == buscador)
                        {
                            contador++;
                        }
                    }
                }
                Console.WriteLine(contador);
            }

            if (nOpcion == 4)
            {
                string datoEntrada1;
                string datoEntrada2;
                int nVeces;
                Console.WriteLine("Inserte una palabra");
                datoEntrada1 = Console.ReadLine();
                Console.WriteLine("Inserte una palabra");
                datoEntrada2 = Console.ReadLine();
                comprobacion = true;
                while (comprobacion)
                {
                    Console.WriteLine("Cuantas veces que se repita");
                    entrada = Console.ReadLine();
                    if (!int.TryParse(entrada, out tamaño))
                    {
                        Console.WriteLine("Ha Introducido un formato incorrecto");
                    }
                    else
                    {
                        if (tamaño >= 0)
                        {
                            comprobacion = false;
                        }
                        else
                        {
                            Console.WriteLine("La cantidadad introducida no es valida");
                        }
                    }
                }
                for(int i = 0; i < tamaño; i++)
                {
                    Console.Write(datoEntrada1 + " " + datoEntrada2 + " ");
                }
            }

            if (nOpcion == 5)
            {
                string? datoEntrada;
                Console.WriteLine("Inserte una palabra");
                datoEntrada = Console.ReadLine();
                for(int i = 0; i < datoEntrada.Length; i++)
                {
                    Console.Write(datoEntrada[i] +""+ datoEntrada[i]);
                }
            }

            if (nOpcion == 6)
            {
                string? cadena1;
                string? palabra = "";
                string? cadena2;
                string cadenafinal = "";
                Console.WriteLine("Inserte una frase");
                cadena1 = Console.ReadLine();
                Console.WriteLine("Inserte una segunda frase");
                cadena2 = Console.ReadLine();
                for (int i = 0; i < cadena1.Length; i++)
                {
                    if (cadena1[i] != ' ')
                    {
                        palabra = palabra + cadena1[i];
                    }
                    if (cadena1[i] == ' ')
                    {
                        if (palabra != cadena2)
                        {
                            cadenafinal = cadenafinal + palabra + " ";
                        }
                        palabra = "";
                    }
                }
                if (palabra != cadena2)
                {
                    cadenafinal = cadenafinal + palabra;
                }
                Console.WriteLine(cadenafinal);
            }
        }
    }
}