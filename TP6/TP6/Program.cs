using System;
using System.Linq;

namespace TP6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ejercicio 1

            //VARIABLES
            string cadena;
            int numero;

            //Se pide el ingreso de un numero
            Console.WriteLine("Ingrese un numero: ");
            cadena = Console.ReadLine();

            //Convertimos la cadena leida a entero
            numero = Convert.ToInt32(cadena);

            //Si el numero es mayor o igual a 0
            if (numero >= 0)
            {
                //Se da vuelta la cadena
                cadena = String.Concat(cadena.Reverse());

                //Se convierte la cadena invertida a entero
                numero = Convert.ToInt32(cadena);

                //Mostramos el numero invertido
                Console.WriteLine("Numero invertido: " + numero);
            }
            else
            {
                //Mostramos el numero convertido pero sin modificar
                Console.WriteLine("Numero sin modificar: " + numero);
            }
        }
    }
}
