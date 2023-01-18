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
            string entrada;
            int nOpcion = 0;
            int datoIntroducido = 0;
            int introducir = 0;
            bool comprobacion = true;
            while (comprobacion)
            {
                Console.WriteLine("Elige una de las siguientes opciones:");
                Console.WriteLine("        1  Primo\r\n        2 Factorial\r\n        3 Numero en segundos\r\n        4 Devolver los primeros 15 números de la serie de Pell\r\n        5 número de Armstrong \r\n        6 dígitos diferentes");
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
                if (nOpcion == 1)
                {
                    int resultado = 0;
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
                        if(datoIntroducido != contador)
                        {
                            if(datoIntroducido%contador == 0)
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

                }

                if (nOpcion == 2)
                {
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
                    for(int i = 1; i < datoIntroducido + 1; i++)
                    {
                        factorial *= i;
                    }
                    Console.WriteLine("El factorial es " + factorial);
                }

                if (nOpcion == 3)
                {
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

                    Console.WriteLine("Son " + hora + " horas "+minutos+ " minutos y " + segundos);
                }

                if (nOpcion == 4)
                {
                    int tamaño = 15 - 2;
                    int a = 1;
                    int n = 2;
                    int resultado = 0;
                    Console.WriteLine("Los numeros de la serie Pell son");
                    Console.WriteLine(a);
                    Console.WriteLine(n);
                    for (int i = 0; i < tamaño; i++)
                    {
                        
                        a += (n*2);
                        n = n + a;
                        a = n - a;
                        n = n - a;
                        Console.WriteLine(n);

                    }
                }



                if (nOpcion == 5)
                {
                    int suma = 0;
                    int tamaño = 0;
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
                                tamaño = entrada.Length;
                            }
                            else
                            {
                                Console.WriteLine("No es posible calcular si es amstrong o no");
                            }
                        }
                    }
                    
                    int[] listado = new int[tamaño];
                    for(int i = 0; i < tamaño; i++)
                    {
                        int aux = 0;
                        int base10 = 10;
                        int base11 = 10;
                        aux = datoIntroducido;
                        base11 = (int)Math.Pow(base11, i);
                        aux = aux / base11;
                        aux = aux % base10;
                        listado[i] = aux;
                    }
                    for(int i = 0; i < listado.Length; i++)
                    {
                        int aux = 0;

                        aux = (int)Math.Pow(listado[i], tamaño);
                        suma = suma + aux;

                    }
                    if(suma == datoIntroducido)
                    {
                        Console.WriteLine("Es un numero amstong");
                    }
                    else
                    {
                        Console.WriteLine("No es un numero Amstrong");
                    }
                }




                if (nOpcion == 6)
                {
                    int suma = 0;
                    int tamaño = 0;
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

                    int[] listado = new int[tamaño];
                    for (int i = 0; i < tamaño; i++)
                    {
                        int aux = 0;
                        int base10 = 10;
                        int base11 = 10;
                        aux = datoIntroducido;
                        base11 = (int)Math.Pow(base11, i);
                        aux = aux / base11;
                        aux = aux % base10;
                        listado[i] = aux;
                    }
                    comprobacion = true;
                    for (int i = 0; i < listado.Length; i++)
                    {
                        for (int j = 0; j < listado.Length; j++)
                        {

                            if (listado[i] == listado[j])
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
                }
            }
        }
    }
}