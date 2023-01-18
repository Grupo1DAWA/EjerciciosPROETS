using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Decimales
{
    class MainClass
    {

        public static void Main(string[] args)
        {
            string entrada;
            int nOpcion = 0;
            double datoEntrada = 0;
            int introducir = 0;
            bool comprobacion = true;
            while (comprobacion)
            {
                Console.WriteLine("Elige una de las siguientes opciones:");
                Console.WriteLine("        1  Redondear\r\n        2  Borrar\r\n        3 ecuacion segundo grado");
                entrada = Console.ReadLine();
                if (!int.TryParse(entrada, out nOpcion))
                {
                    Console.WriteLine("Ha Introducido un formato incorrecto");
                }
                else
                {
                    if (nOpcion == 1 || nOpcion == 2 || nOpcion == 3)
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
                    comprobacion = true;
                    while (comprobacion)
                    {
                        Console.WriteLine("Introduce un numero");
                        entrada = Console.ReadLine();
                        if (!double.TryParse(entrada, out datoEntrada))
                        {
                            Console.WriteLine("Ha Introducido un formato incorrecto");
                        }
                        else
                        {

                            comprobacion = false;
                        }
                    }

                    if(datoEntrada > 0)
                    {
                        datoEntrada = Math.Round(datoEntrada) + 1;
                    }
                    else
                    {
                        datoEntrada = Math.Round(datoEntrada);
                    }
                    
                    Console.WriteLine("El resultado es "+ datoEntrada);
                }

                if (nOpcion == 2)
                {
                    
                    comprobacion = true;
                    while (comprobacion)
                    {
                        Console.WriteLine("Introduce un numero");
                        entrada = Console.ReadLine();
                        if (!double.TryParse(entrada, out datoEntrada))
                        {
                            Console.WriteLine("Ha Introducido un formato incorrecto");
                        }
                        else
                        {

                            comprobacion = false;
                        }
                    }

                    datoEntrada = Math.Truncate(datoEntrada);

                    Console.WriteLine("El resultado es " + datoEntrada);
                }

                if (nOpcion == 3)
                {
                    double a = 0;
                    double b = 0;
                    double c = 0;
                    double resul1 = 0;
                    double resul2 = 0;

                    comprobacion = true;
                    while (comprobacion)
                    {
                        Console.WriteLine("Introduce un numero");
                        entrada = Console.ReadLine();
                        if (!double.TryParse(entrada, out a) )
                        {
                            Console.WriteLine("Ha Introducido un formato incorrecto");
                        }
                        else
                        {

                            if(a > 0)
                            {
                                comprobacion = false;
                            }
                            else
                            Console.WriteLine("Ha Introducido un formato incorrecto");
                        }
                    }

                    comprobacion = true;
                    while (comprobacion)
                    {
                        Console.WriteLine("Introduce un numero");
                        entrada = Console.ReadLine();
                        if (!double.TryParse(entrada, out b))
                        {
                            Console.WriteLine("Ha Introducido un formato incorrecto");
                        }
                        else
                        {

                            if (a > 0)
                            {
                                comprobacion = false;
                            }
                            else
                                Console.WriteLine("Ha Introducido un formato incorrecto");
                        }
                    }

                    comprobacion = true;
                    while (comprobacion)
                    {
                        Console.WriteLine("Introduce un numero");
                        entrada = Console.ReadLine();
                        if (!double.TryParse(entrada, out c))
                        {
                            Console.WriteLine("Ha Introducido un formato incorrecto");
                        }
                        else
                        {

                            if (a > 0)
                            {
                                comprobacion = false;
                            }
                            else
                                Console.WriteLine("Ha Introducido un formato incorrecto");
                        }
                    }
                    double parteAbajo = 2 * a;
                    double cuadrado = b * b;
                    double resta = 4 * a * c;
                    double rCont = cuadrado - resta;
                    double raiz = Math.Sqrt(rCont);
                    if(raiz > 0)
                    {
                        resul1 = -b + raiz;
                        resul1 = resul1 / parteAbajo;
                        resul2 = -b - raiz;
                        resul2 = resul2 / parteAbajo;
                        Console.WriteLine("Las soluciones son " + resul1 + " y " + resul2);
                    }
                    else
                    {
                        Console.WriteLine("No tiene solucion");
                    }
                    
                }
            }
        }
    }
}