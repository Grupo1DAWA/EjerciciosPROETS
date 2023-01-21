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
            int opcion;
            bool comprobarentrada = false;
            do
            {
                Console.WriteLine("Menú");
                Console.WriteLine("1) Palíndromo");
                Console.WriteLine("2) Mayusculas y Minusculas");
                Console.WriteLine("3) Número de ocurrencias");
                Console.WriteLine("4) Número de ocurrencias");
                Console.WriteLine("5) Repetir Frase");
                Console.WriteLine("6) Número de ocurrencias");
                Console.WriteLine("7) Salir");
                do
                {
                    Console.Write("Escoge una opción: ");
                    while (!Int32.TryParse(Console.ReadLine(), out opcion))
                    {
                        Console.WriteLine("Debe introducir un número de las opciones");
                    }
                    if (opcion == 1 || opcion == 2 || opcion == 3 || opcion == 4 || opcion == 5 || opcion == 6 || opcion == 7)
                    {
                        comprobarentrada = true;
                    }
                    else
                    {
                        Console.WriteLine("Introduzca un número de las opciones");
                    }
                } while (!comprobarentrada);
                switch (opcion)
                {
                    case 1:
                        string? datoEntrada = "";
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
                        Console.WriteLine("Presiona una tecla para elegir otra opción");
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case 2:
                        string? entrada = "";
                        string? mayusculas = "";
                        string? minusculas = "";
                        Console.WriteLine("Inserte una palabra");
                        entrada = Console.ReadLine();
                        mayusculas = entrada.ToUpper();
                        minusculas = entrada.ToLower();
                        Console.WriteLine("La frase introducida es: " + entrada + "\nEn minusculas es " + minusculas + "\nY en mayusculas " + mayusculas);
                        Console.WriteLine("Presiona una tecla para elegir otra opción");
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case 3:
                        string? entra = "";
                        char buscador;
                        string? convertir = "";
                        int contador = 0;
                        Console.WriteLine("Inserte una frase");
                        entra = Console.ReadLine();
                        Console.WriteLine("Introduce un caracter");
                        convertir = Console.ReadLine();
                        for (int i = 0; i < entra.Length; i++)
                        {
                            if (entra.Contains(convertir))
                            {
                                contador++;
                            }
                            else
                            {
                                Console.WriteLine("El valor no es valido");
                            }
                        }
                        Console.WriteLine("Se ha repetido: " + contador + " vez/ces");
                        Console.WriteLine("Presiona una tecla para elegir otra opción");
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case 4:
                        string? datoEntrada1 = "";
                        string? datoEntrada2 = "";
                        int tamano = 0;
                        int nVeces;
                        Console.WriteLine("Inserte una palabra");
                        datoEntrada1 = Console.ReadLine();
                        Console.WriteLine("Inserte una palabra");
                        datoEntrada2 = Console.ReadLine();
                        bool comprobacion = true;
                        while (comprobacion)
                        {
                            Console.WriteLine("Cuantas veces quieres que se repita");
                            entrada = Console.ReadLine();
                            if (!int.TryParse(entrada, out tamano))
                            {
                                Console.WriteLine("Ha Introducido un formato incorrecto");
                            }
                            else
                            {
                                if (tamano >= 0)
                                {
                                    comprobacion = false;
                                }
                                else
                                {
                                    Console.WriteLine("La cantidadad introducida no es valida");
                                }
                            }
                        }
                        for (int i = 0; i < tamano; i++)
                        {
                            Console.Write(datoEntrada1 + " " + datoEntrada2 + " ");
                        }
                        Console.WriteLine("Presiona una tecla para elegir otra opción");
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case 5:
                        string? frase = "";
                        Console.WriteLine("Inserte una palabra");
                        frase = Console.ReadLine();
                        for (int i = 0; i < frase.Length; i++)
                        {
                            Console.Write(frase[i] + "" + frase[i]);
                        }
                        Console.WriteLine("Presiona una tecla para elegir otra opción");
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case 6:
                        string? cadena1 = "";
                        string? palabra = "";
                        string? cadena2 = "";
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
                        Console.WriteLine("Presiona una tecla para elegir otra opción");
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case 7:
                        Console.WriteLine("Adiós");
                        break;
                }
            } while (opcion != 7);
        }
    }
}