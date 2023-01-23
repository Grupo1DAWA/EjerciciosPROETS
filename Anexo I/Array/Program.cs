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
            int tamanioArray,option;
            Console.WriteLine("Dime el tamaño del array");
            while (!int.TryParse(Console.ReadLine(), out tamanioArray))
            {
                global::System.Console.WriteLine("Dato inválido");
            }
            int[] arrayMain = new int[tamanioArray];
            for (int i = 0;i<tamanioArray;i++)
            {
                global::System.Console.WriteLine("Introduce números para llenar el array: {0}/{1}",i,tamanioArray);
                while (!int.TryParse(Console.ReadLine(), out option))
                {
                    global::System.Console.WriteLine("Dato inválido");
                }
                arrayMain[i] = option;
            }
            MenuMain();
            while (int.TryParse(Console.ReadLine(), out option))
            {
                switch (option)
                {
                    case 1: Ejercicios.CalcularMinimo(arrayMain); break;
                    case 2: Ejercicios.CalcularMaximo(arrayMain); break;
                    case 3: Ejercicios.CalcularMediana(arrayMain); break;
                    case 4: Ejercicios.CalcularMedia(arrayMain); break;
                    case 5: Ejercicios.OrdenarArray(arrayMain); break;
                    case 6: Ejercicios.BinamizarArray(arrayMain); break;
                }

            }
            global::System.Console.WriteLine("Pulsa una tecla para finalizar");
            Console.ReadKey();
            
        }
        private static void MenuMain()
        {
            global::System.Console.WriteLine("Selecciona operacion");
            global::System.Console.WriteLine("1. Calcular minimo");
            global::System.Console.WriteLine("2. Calcular maximo");
            global::System.Console.WriteLine("3. Calcular mediana");
            global::System.Console.WriteLine("4. Calcular media");
            global::System.Console.WriteLine("5. Ordenar Array");
            global::System.Console.WriteLine("6. Binarizar Array");
        }
    }
    class Ejercicios
    {
        public static void CalcularMinimo(int[] Listado)
        {
            int menor = Listado[0];
            for (int i = 0; i < Listado.Length; i++)
            {
                if (menor > Listado[i])
                {
                    menor = Listado[i];
                }
            }
            global::System.Console.WriteLine("El menor número es: {0}", menor);
        }
        public static void CalcularMaximo(int[] Listado)
        {
            int mayor = Listado[0];
            for (int i = 0; i < Listado.Length; i++)
            {
                if (mayor < Listado[i])
                {
                    mayor = Listado[i];
                }
            }
            global::System.Console.WriteLine("El mayor número es: {0}", mayor);
        }
        public static void CalcularMediana(int[] Listado)
        {
            for (int k = 0; k < Listado.Length; k++)
            {
                for (int f = 0; f < Listado.Length - 1 - k; f++)
                {
                    if (Listado[f] > Listado[f + 1])
                    {
                        int aux = Listado[f];
                        Listado[f] = Listado[f + 1];
                        Listado[f + 1] = aux;
                    }
                }
            }
            int total = Listado.Length;
            if (Listado.Length % 2 == 0)
            {
                Console.WriteLine("la mediana es: {1} y {0}", Listado[total / 2], Listado[(total / 2) - 1]);
            }
            else
            {
                Console.WriteLine("la mediana es: " + Listado[total / 2]);
            }
        }
        public static void CalcularMedia(int[] Listado)
        {
            int total = 0;
            decimal media;
            for (int i = 0; i < Listado.Length; i++)
            {
                total += Listado[i];
            }
            media = total / Listado.Length;
            global::System.Console.WriteLine("La media es: " + media);
        }
        public static void OrdenarArray(int[] Listado)
        {
            for (int k = 0; k < Listado.Length; k++)
            {
                for (int f = 0; f < Listado.Length - 1 - k; f++)
                {
                    if (Listado[f] > Listado[f + 1])
                    {
                        int aux = Listado[f];
                        Listado[f] = Listado[f + 1];
                        Listado[f + 1] = aux;
                    }
                }
            }
            for (int k = 0; k < Listado.Length - 1; k++)
            {
                Console.WriteLine(Listado[k]);
            }
            
        }
        public static void BinamizarArray(int[] Listado)
        {
            int binar;
            global::System.Console.WriteLine("Da número medio para binarizar");
            while (!int.TryParse(Console.ReadLine(), out binar))
            {
                global::System.Console.WriteLine("Dato inválido");
            }
            for (int i = 0; i < Listado.Length; i++)
            {
                if (Listado[i] < binar)
                {
                    Console.Write("0");
                } 
                else
                {
                    Console.Write("1");
                }
                Console.Write(" ");
            }
        }
    }
}