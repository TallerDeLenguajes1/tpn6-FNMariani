using System;
using System.Collections.Generic;
using System.Text;

namespace TP6
{
    class Ej3
    {
        public void ejercicio3()
        {
            //VARIABLES
            double numero1, numero2;

            //Se pide un numero
            Console.WriteLine("Ingrese un numero: ");
            numero1 = Convert.ToDouble(Console.ReadLine());

            //Se calcula utilizando Math
            Console.WriteLine("\nValor Absoluto: " + Math.Abs(numero1));
            Console.WriteLine("Cuadrado: " + Math.Pow(numero1, 2));
            Console.WriteLine("Raiz Cuadrada: " + Math.Sqrt(numero1));
            Console.WriteLine("Seno: " + Math.Sin( (numero1 * Math.PI)/180) );
            Console.WriteLine("Coseno: " + Math.Cos( (numero1 * Math.PI)/180 ));
            Console.WriteLine("Parte entera: " + Math.Truncate(numero1));

            //Se pide dos numeros
            Console.WriteLine("\nIngrese un numero: ");
            numero1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese otro numero: ");
            numero2 = Convert.ToDouble(Console.ReadLine());

            //Se muestra maximo y minimo
            Console.WriteLine("Maximo: " + Math.Max(numero1, numero2));
            Console.WriteLine("Minimo: " + Math.Min(numero1, numero2));
        }
    }
}
