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
            for (int i = 0;int<tamanioArray;i++)
            {
                global::System.Console.WriteLine("Introduce números para llenar el array: {0}/{1}",i,tamanioArray);
                while (!int.TryParse(Console.ReadLine(), out option))
                {
                    global::System.Console.WriteLine("Dato inválido");
                }
                arrayMain[i] = option;
            }
            MenuMain();
            while (int.TryParse(console.ReadLine(), out option))
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
        public static void CalcularMinimo(int[] array)
        {
            int menor = array[0];
            for (int i = 0; i < array.lenght; i++)
            {
                if (menor > array[i])
                {
                    menor = array[i];
                }
            }
            global::System.Console.WriteLine("El menor número es: {0}", menor);
        }
        public static void CalcularMaximo(int[] array)
        {
            int mayor = array[0];
            for (int i = 0; i < array.lenght; i++)
            {
                if (mayor < array[i])
                {
                    mayor = array[i];
                }
            }
            global::System.Console.WriteLine("El mayor número es: {0}", mayor);
        }
        public static void CalcularMediana(int[] array)
        {
            int total = 0;
            decimal media;
            for (int i = 0; i < array.Lenght; i++)
            {
                total += array[i];
            }
            media = total/array.Lenght;
            global::System.Console.WriteLine("La mediana es: " + media);
        }
        public static void CalcularMedia(int[] array)
        {
            int total = 0;
            decimal mediana;
            for (int i = 0; i < array.Lenght; i++)
            {
                total += array[i];
            }
            mediana = total / 2;
            global::System.Console.WriteLine("La mediana es: " + mediana);
        }
        public static void OrdenarArray(int[] array)
        {

        }
        public static void BinamizarArray(int[] array)
        {
            int binar;
            global::System.Console.WriteLine("Da número medio para binarizar");
            while (!int.TryParse(Console.ReadLine(), out binar))
            {
                global::System.Console.WriteLine("Dato inválido");
            }
            for (int i = 0; i < array.Lenght; i++)
            {
                if (array[i] < binar)
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
/*

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

    for (int i = 0; i < listado.Length; i++)
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
*/