using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;

namespace Numeros
{
    class MainClass
    {

        public static void Main(string[] args)
        {
            int variable;
            int opcion;
            bool comprobarentrada = false;
            string entrada;
            int datoIntroducido = 0;
            bool comprobacion = true;
            do
            {
                Console.WriteLine("Menú");
                Console.WriteLine("1) Primo");
                Console.WriteLine("2) Factorial");
                Console.WriteLine("3) Número en segundos");
                Console.WriteLine("4) Devolver los primeros 15 números de la serie de Pell");
                Console.WriteLine("5) número de Armstrong");
                Console.WriteLine("6) dígitos diferentes");
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
                switch(opcion)
                {

                    case 1:
                        
                        int contador = 2;
                        comprobacion = true;
                        while (comprobacion)
                        {
                            Console.WriteLine("Introduce un numero");
                            entrada = Console.ReadLine();
                            if (!int.TryParse(entrada, out datoIntroducido))
                            {
                                Console.WriteLine("Ha Introducido un formato incorrecto");
                            }
                            else
                            {
                                if (datoIntroducido >= 0)
                                {
                                    comprobacion = false;
                                }
                                else
                                {
                                    Console.WriteLine("No es posible calcular si es primo o no");
                                }
                            }

                        }
                        comprobacion = true;
                        while (comprobacion)
                        {
                            if (datoIntroducido != contador)
                            {
                                if (datoIntroducido % contador == 0)
                                {
                                    Console.WriteLine("No es primo");
                                    comprobacion = false;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Es primo");
                                comprobacion = false;
                            }
                            contador++;
                        }
                        break;

                    case 2:
                        int factorial = 1;
                        comprobacion = true;
                        while (comprobacion)
                        {
                            Console.WriteLine("Introduce un numero");
                            entrada = Console.ReadLine();
                            if (!int.TryParse(entrada, out datoIntroducido))
                            {
                                Console.WriteLine("Ha Introducido un formato incorrecto");
                            }
                            else
                            {
                                if (datoIntroducido >= 0)
                                {
                                    comprobacion = false;
                                }
                                else
                                {
                                    Console.WriteLine("No es posible calcular su factorial");
                                }
                            }
                        }
                        for (int i = 1; i < datoIntroducido + 1; i++)
                        {
                            factorial *= i;
                        }
                        Console.WriteLine("El factorial es " + factorial);
                        break;

                    case 3:
                        int hora = 0;
                        int minutos = 0;
                        int aux = 0;
                        int segundos = 0;
                        comprobacion = true;
                        while (comprobacion)
                        {
                            Console.WriteLine("Introduce un numero");
                            entrada = Console.ReadLine();
                            if (!int.TryParse(entrada, out datoIntroducido))
                            {
                                Console.WriteLine("Ha Introducido un formato incorrecto");
                            }
                            else
                            {
                                if (datoIntroducido > 0)
                                {
                                    comprobacion = false;
                                }
                                else
                                {
                                    Console.WriteLine("No es posible calcular la hora");
                                }
                            }
                        }
                        hora = datoIntroducido / 3600;
                        aux = datoIntroducido % 3600;
                        minutos = aux / 60;
                        segundos = aux % 60;

                        Console.WriteLine("Son " + hora + " horas " + minutos + " minutos y " + segundos);
                        break;
                    case 4:
                        int tamaño = 15 - 2;
                        int a = 1;
                        int n = 2;
                        
                        Console.WriteLine("Los numeros de la serie Pell son");
                        Console.WriteLine(a);
                        Console.WriteLine(n);
                        for (int i = 0; i < tamaño; i++)
                        {

                            a += (n * 2);
                            n = n + a;
                            a = n - a;
                            n = n - a;
                            Console.WriteLine(n);

                        }
                        break;
                    case 5:
                        int suma = 0;
                        int tamaño1 = 0;
                        comprobacion = true;
                        while (comprobacion)
                        {
                            Console.WriteLine("Introduce un numero");
                            entrada = Console.ReadLine();
                            if (!int.TryParse(entrada, out datoIntroducido))
                            {
                                Console.WriteLine("Ha Introducido un formato incorrecto");
                            }
                            else
                            {
                                if (datoIntroducido > 0)
                                {
                                    comprobacion = false;
                                    tamaño1 = entrada.Length;
                                }
                                else
                                {
                                    Console.WriteLine("No es posible calcular si es amstrong o no");
                                }
                            }
                        }
                  
                        int[] listado = new int[tamaño1];
                        for (int i = 0; i < tamaño1; i++)
                        {
                            int aux1 = 0;
                            int base10 = 10;
                            int base11 = 10;
                            aux1 = datoIntroducido;
                            base11 = (int)Math.Pow(base11, i);
                            aux1 = aux1 / base11;
                            aux1 = aux1 % base10;
                            listado[i] = aux1;
                        }
                        for (int i = 0; i < listado.Length; i++)
                        {
                            int aux1 = 0;

                            aux1 = (int)Math.Pow(listado[i], tamaño1);
                            suma = suma + aux1;

                        }
                        if (suma == datoIntroducido)
                        {
                            Console.WriteLine("Es un numero Armstrong");
                        }
                        else
                        {
                            Console.WriteLine("No es un numero Armstrong");
                        }
                        break;
                    case 6:
                       
                        int tamaño2 = 0;
                        comprobacion = true;
                        while (comprobacion)
                        {
                            Console.WriteLine("Introduce un numero");
                            entrada = Console.ReadLine();
                            if (!int.TryParse(entrada, out datoIntroducido))
                            {
                                Console.WriteLine("Ha Introducido un formato incorrecto");
                            }
                            else
                            {

                                comprobacion = false;
                                tamaño = entrada.Length;


                            }
                        }

                        int[] listado1 = new int[tamaño2];
                        for (int i = 0; i < tamaño2; i++)
                        {
                            int aux2 = 0;
                            int base10 = 10;
                            int base11 = 10;
                            aux2 = datoIntroducido;
                            base11 = (int)Math.Pow(base11, i);
                            aux2 = aux2 / base11;
                            aux2 = aux2 % base10;
                            listado1[i] = aux2;
                        }
                        comprobacion = true;
                        for (int i = 0; i < listado1.Length; i++)
                        {
                            for (int j = 0; j < listado1.Length; j++)
                            {

                                if (listado1[i] == listado1[j])
                                {
                                    comprobacion = false;
                                }
                            }
                        }
                        if (comprobacion)
                        {
                            Console.WriteLine("No todos los digitos son iguales");
                        }
                        else
                        {
                            Console.WriteLine("Todos los digitos son iguales");
                        }
                        break;
                    case 7:
                        Console.WriteLine("Adiós");
                        break;
                    default:
                        break;
                }
                
            }while (opcion!= 7) ;
        }
    }
}