using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Array
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
                Console.WriteLine("        1 Calcular máximo\r\n        2 Calcular mínimo\r\n        3 Calcular la mediana\r\n        4 Calcular la media\r\n        5 Ordenar un Array de menor a mayor\r\n        6 Calcular la desviación típica de un array\r\n        7 Binarizar un array en base a un número n.");
                entrada = Console.ReadLine();
                if (!int.TryParse(entrada, out nOpcion))
                {
                    Console.WriteLine("Ha Introducido un formato incorrecto");
                }
                else
                {
                    if (nOpcion == 1 || nOpcion == 2 || nOpcion == 3 || nOpcion == 4 || nOpcion == 5 || nOpcion == 6 || nOpcion == 7)
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
                int nMayor = 0;
                comprobacion = true;
                while (comprobacion)
                {
                    Console.WriteLine("Cunatos elementos quieres introducir?");
                    entrada = Console.ReadLine();
                    if (!int.TryParse(entrada, out tamaño))
                    {
                        Console.WriteLine("Ha Introducido un formato incorrecto");
                    }
                    else
                    {
                        if (tamaño > 0)
                        {
                            comprobacion = false;
                        }
                        else
                        {
                            Console.WriteLine("El tamaño introducido no es valido");
                        }
                    }
                }

                int[] listado = new int[tamaño];


                for (int i = 0; i < listado.Length; i++)
                {
                    comprobacion = true;
                    while (comprobacion)
                    {
                        Console.WriteLine("Inserte un valor");
                        entrada = Console.ReadLine();
                        if (!Int32.TryParse(entrada, out introducir))
                        {
                            Console.WriteLine("El formato introducido es incorrecto");
                        }
                        else
                        {
                            comprobacion = false;
                        }
                    }
                    listado[i] = introducir;
                }
                for (int i = 0; i < listado.Length; i++)
                {
                    if (i == 0)
                    {
                        nMayor = listado[i];
                    }
                    if (nMayor < listado[i])
                    {
                        nMayor = listado[i];

                    }
                }
                Console.WriteLine("El numero mayor es " + nMayor);
            }



            if (nOpcion == 2)
            {
                int nMenor = 0;
                comprobacion = true;
                while (comprobacion)
                {
                    Console.WriteLine("Cunatos elementos quieres introducir?");
                    entrada = Console.ReadLine();
                    if (!int.TryParse(entrada, out tamaño))
                    {
                        Console.WriteLine("Ha Introducido un formato incorrecto");
                    }
                    else
                    {
                        if (tamaño > 0)
                        {
                            comprobacion = false;
                        }
                        else
                        {
                            Console.WriteLine("El tamaño introducido no es valido");
                        }
                    }
                }

                int[] listado = new int[tamaño];


                for (int i = 0; i < listado.Length; i++)
                {
                    comprobacion = true;
                    while (comprobacion)
                    {
                        Console.WriteLine("Inserte un valor");
                        entrada = Console.ReadLine();
                        if (!int.TryParse(entrada, out introducir))
                        {
                            Console.WriteLine("El formato introducido es incorrecto");
                        }
                        else
                        {
                            comprobacion = false;
                        }
                    }
                    listado[i] = introducir;
                }
                for (int i = 0; i < listado.Length; i++)
                {
                    if (i == 0)
                    {
                        nMenor = listado[i];
                    }
                    if (nMenor > listado[i])
                    {
                        nMenor = listado[i];

                    }
                }
                Console.WriteLine("El numero menor es " + nMenor);

            }


            if (nOpcion == 3) //COMPROBAR
            {
                int suma = 0;
                int decrece = 0;
                int crece = 0;
                int contador = 0;
                comprobacion = true;
                while (comprobacion)
                {
                    Console.WriteLine("Cunatos elementos quieres introducir?");
                    entrada = Console.ReadLine();
                    if (!int.TryParse(entrada, out tamaño))
                    {
                        Console.WriteLine("Ha Introducido un formato incorrecto");
                    }
                    else
                    {
                        if (tamaño > 0)
                        {
                            comprobacion = false;
                        }
                        else
                        {
                            Console.WriteLine("El tamaño introducido no es valido");
                        }
                    }
                }

                int[] listado = new int[tamaño];

                for (int i = 0; i < listado.Length; i++)
                {
                    comprobacion = true;
                    while (comprobacion)
                    {
                        Console.WriteLine("Inserte un valor");
                        entrada = Console.ReadLine();
                        if (!int.TryParse(entrada, out introducir))
                        {
                            Console.WriteLine("El formato introducido es incorrecto");
                        }
                        else
                        {
                            comprobacion = false;
                        }
                    }
                    listado[i] = introducir;
                }

                for (int i = 0; i < listado.Length; i++)
                {
                    suma = suma + listado[i];
                }
                suma = suma / listado.Length;
                crece = suma;
                decrece = suma;
                comprobacion = true;
                while (comprobacion)
                {
                    if (crece == listado[contador])
                    {
                        crece = listado[contador];
                        crece--;
                        comprobacion = false;
                    }
                    if (decrece == listado[contador])
                    {
                        decrece = listado[contador];
                        decrece++;
                        comprobacion = false;
                    }
                    contador++;
                    crece++;
                    decrece--;
                }
                if(crece == 0)
                {
                    Console.WriteLine("La mediana es " + decrece);
                }
                else
                {
                    if(decrece == 0)
                    {
                        Console.WriteLine("La mediana es " + crece);
                    }
                    else
                    {
                        Console.WriteLine("Las medianas son " + crece + " y "+ decrece);
                    }
                }
            }


            if (nOpcion == 4)
            {
                double media = 0;
                int suma = 0;
                int decrece = 0;
                int crece = 0;
                int contador = 0;
                comprobacion = true;
                while (comprobacion)
                {
                    Console.WriteLine("Cunatos elementos quieres introducir?");
                    entrada = Console.ReadLine();
                    if (!int.TryParse(entrada, out tamaño))
                    {
                        Console.WriteLine("Ha Introducido un formato incorrecto");
                    }
                    else
                    {
                        if (tamaño > 0)
                        {
                            comprobacion = false;
                        }
                        else
                        {
                            Console.WriteLine("El tamaño introducido no es valido");
                        }
                    }
                }

                int[] listado = new int[tamaño];

                for (int i = 0; i < listado.Length; i++)
                {
                    comprobacion = true;
                    while (comprobacion)
                    {
                        Console.WriteLine("Inserte un valor");
                        entrada = Console.ReadLine();
                        if (!int.TryParse(entrada, out introducir))
                        {
                            Console.WriteLine("El formato introducido es incorrecto");
                        }
                        else
                        {
                            comprobacion = false;
                        }
                    }
                    listado[i] = introducir;
                }

                for (int i = 0; i < listado.Length; i++)
                {
                    media = media + listado[i];
                }
                media = media / listado.Length;
                Console.WriteLine("La media es "+ media);
            }


            if (nOpcion == 5)
            {
                comprobacion = true;
                while (comprobacion)
                {
                    Console.WriteLine("Cunatos elementos quieres introducir?");
                    entrada = Console.ReadLine();
                    if (!int.TryParse(entrada, out tamaño))
                    {
                        Console.WriteLine("Ha Introducido un formato incorrecto");
                    }
                    else
                    {
                        if (tamaño > 0)
                        {
                            comprobacion = false;
                        }
                        else
                        {
                            Console.WriteLine("El tamaño introducido no es valido");
                        }
                    }
                }
                int[] listado = new int[tamaño];

                for (int i = 0; i < listado.Length; i++)
                {
                    comprobacion = true;
                    while (comprobacion)
                    {
                        Console.WriteLine("Inserte un valor");
                        entrada = Console.ReadLine();
                        if (!int.TryParse(entrada, out introducir))
                        {
                            Console.WriteLine("El formato introducido es incorrecto");
                        }
                        else
                        {
                            comprobacion = false;
                        }
                    }
                    listado[i] = introducir;
                }
                int[] nuevoListado = new int[tamaño];


                for (int k = 0; k < tamaño; k++)
                {
                    for (int f = 0; f < tamaño - 1 - k; f++)
                    {
                        if (listado[f] > listado[f + 1])
                        {
                            int aux;
                            aux = listado[f];
                            listado[f] = listado[f + 1];
                            listado[f + 1] = aux;
                        }
                    }
                }
                for (int k = 0; k < tamaño - 1; k++)
                {
                    Console.WriteLine(listado[k]);
                }
                

            }



            

            if (nOpcion == 6) //COMPROBAR
            {
                comprobacion = true;
                double media = 0;
                double suma = 0;
                double suma2 = 0;
                double varianza = 0;
                double resultado = 0;
                while (comprobacion)
                {
                    Console.WriteLine("Cunatos elementos quieres introducir?");
                    entrada = Console.ReadLine();
                    if (!int.TryParse(entrada, out tamaño))
                    {
                        Console.WriteLine("Ha Introducido un formato incorrecto");
                    }
                    else
                    {
                        if (tamaño > 0)
                        {
                            comprobacion = false;
                        }
                        else
                        {
                            Console.WriteLine("El tamaño introducido no es valido");
                        }
                    }
                }

                int[] listado = new int[tamaño];
                double[] desviacion = new double[tamaño];

                for (int i = 0; i < listado.Length; i++)
                {
                    comprobacion = true;
                    while (comprobacion)
                    {
                        Console.WriteLine("Inserte un valor");
                        entrada = Console.ReadLine();
                        if (!int.TryParse(entrada, out introducir))
                        {
                            Console.WriteLine("El formato introducido es incorrecto");
                        }
                        else
                        {
                            comprobacion = false;
                        }
                    }
                    listado[i] = introducir;
                }

                for (int i = 0; i < listado.Length; i++)
                {
                    suma = suma + listado[i];
                }
                media = suma / listado.Length;
                Console.WriteLine("La media es " + media);

                for(int i = 0; i < listado.Length; i++)
                {
                    desviacion[i] = listado[i] - media;
                    desviacion[i] = desviacion[i] * desviacion[i];
                    suma2 = suma2 + desviacion[i];
                }
                suma = suma - 1;
                varianza = suma2 / suma;

                resultado = Math.Sqrt(varianza);
                Console.WriteLine("la desviacion tipica es " + resultado);
            }



            if (nOpcion == 7)
            {
                int media = 0;
                comprobacion = true;
                while (comprobacion)
                {
                    Console.WriteLine("Cunatos elementos quieres introducir?");
                    entrada = Console.ReadLine();
                    if (!int.TryParse(entrada, out tamaño))
                    {
                        Console.WriteLine("Ha Introducido un formato incorrecto");
                    }
                    else
                    {
                        if (tamaño > 0)
                        {
                            comprobacion = false;
                        }
                        else
                        {
                            Console.WriteLine("El tamaño introducido no es valido");
                        }
                    }
                }

                int[] listado = new int[tamaño];
                int[] listadoFinal = new int[tamaño];

                for (int i = 0; i < listado.Length; i++)
                {
                    comprobacion = true;
                    while (comprobacion)
                    {
                        Console.WriteLine("Inserte un valor");
                        entrada = Console.ReadLine();
                        if (!int.TryParse(entrada, out introducir))
                        {
                            Console.WriteLine("El formato introducido es incorrecto");
                        }
                        else
                        {
                            comprobacion = false;
                        }
                    }
                    listado[i] = introducir;

                }
                comprobacion = true;
                while (comprobacion)
                {
                    Console.WriteLine("Introduce el numero de media");
                    entrada = Console.ReadLine();
                    if (!int.TryParse(entrada, out media))
                    {
                        Console.WriteLine("Ha Introducido un formato incorrecto");
                    }
                    else
                    {
                        comprobacion = false;
                       
                    }
                }
                for(int i = 0; i < listado.Length; i++)
                {
                    if(media <= listado[i])
                    {
                        listadoFinal[i] = 1;
                    }
                    else
                    {
                        listadoFinal[i] = 0;
                    }
                }
                Console.WriteLine("El resultado es:");
                for (int i = 0; i < listado.Length; i++)
                {
                    Console.WriteLine(listadoFinal[i]);
                }
            }
        }
    }
}