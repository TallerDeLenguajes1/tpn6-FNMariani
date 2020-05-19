using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TP6
{
    class Ej4
    {
        public void ejercicio4()
        {
            //VARIABLES
            string cadena, cadena2;
            string[] arreglo_string;
            double numero1, numero2, resultado;

            do
            {
                //Se pide el ingreso de una cadena
                Console.WriteLine("Ingrese una cadena de mas de 5 caracteres: ");
                cadena = (Console.ReadLine());
            } while (cadena.Length < 5);

            //Se opera con la cadena
            Console.WriteLine("\nAlgunas letras: " + cadena[0] + " " + cadena[2] + " " + cadena[4]);
            Console.WriteLine("Longitud de la cadena: " + cadena.Length);

            Console.WriteLine("\nIngrese otra cadena: ");
            cadena2 = (Console.ReadLine());
            cadena = String.Concat(cadena, cadena2);
            Console.WriteLine("Cadenas concatenadas: " + cadena);

            Console.WriteLine("Subcadena: " +  cadena.Substring(0, 3));

            Console.WriteLine("\n\n/////////////////// CALCULADORA ///////////////////");
            calcular();

            //ForEach
            Console.WriteLine("\n\n/////////////////// FOREACH ///////////////////");
            foreach (char c in cadena)
            {
                Console.Write(c + " ");
            }

            //Buscar sub cadena
            Console.WriteLine("\nIngrese la cadena a buscar: ");
            cadena2 = (Console.ReadLine());

            if( cadena.Contains(cadena2) )
            {
                Console.WriteLine("\nLa subcadena existe!");
            }
            else
            {
                Console.WriteLine("\nLa subcadena NO existe!");
            }

            //Se convierte en mayusculas y luego en minusculas
            Console.WriteLine("\nCadena en Mayusculas: " + cadena.ToUpper());
            Console.WriteLine("Cadena en Minusculas: " + cadena.ToLower());

            //Se compara cadenas
            Console.WriteLine("\nIngrese la cadena a comparar: ");
            cadena2 = (Console.ReadLine());

            if (cadena.CompareTo(cadena2) == 0)
            {
                Console.WriteLine("\nLas cadenas son iguales");
            }
            else
            {
                Console.WriteLine("\nLas cadenas NO son iguales");
            }

            //Se utiliza Split
            Console.WriteLine("\nIngrese una cadena separada por comas (,): ");
            cadena2 = (Console.ReadLine());

            Console.WriteLine("\nElementos de la cadena separada: ");
            arreglo_string = cadena2.Split(',');
            for (int i = 0; i < arreglo_string.Length; i++)
            {
                arreglo_string[i] = arreglo_string[i].Trim();
                Console.WriteLine(arreglo_string[i]);
            }

            //Se calcula una expresion
            Console.WriteLine("\nIngrese una expresion para operar (+, -, *, /): ");
            cadena2 = (Console.ReadLine());

            //Suma
            if(cadena2.Contains('+'))
            {
                string[] expresion = cadena2.Split('+');
                resultado = Convert.ToDouble(expresion[0]) + Convert.ToDouble(expresion[1]);
                Console.WriteLine("La suma de " + expresion[0] + " y de " + expresion[1] + " es igual a: " + resultado);
            }
            //Resta
            if (cadena2.Contains('-'))
            {
                string[] expresion = cadena2.Split('-');
                resultado = Convert.ToDouble(expresion[0]) - Convert.ToDouble(expresion[1]);
                Console.WriteLine("La resta de " + expresion[0] + " y de " + expresion[1] + " es igual a: " + resultado);
            }
            //Multiplicacion
            if (cadena2.Contains('*'))
            {
                string[] expresion = cadena2.Split('*');
                resultado = Convert.ToDouble(expresion[0]) * Convert.ToDouble(expresion[1]);
                Console.WriteLine("La multiplicacion de " + expresion[0] + " y de " + expresion[1] + " es igual a: " + resultado);
            }
            //Division
            if (cadena2.Contains('/'))
            {
                string[] expresion = cadena2.Split('/');
                if( (Convert.ToDouble(expresion[1]) != 0) )
                {
                    resultado = Convert.ToDouble(expresion[0]) / Convert.ToDouble(expresion[1]);
                    Console.WriteLine("La division de " + expresion[0] + " y de " + expresion[1] + " es igual a: " + resultado);
                }
                else
                {
                    Console.WriteLine("\nERROR! No se puede dividir con cero!");
                }
            }

        }

        public void calcular()
        {
            //VARIABLES
            string resp;
            int ope;
            double resultado = 0, numero1, numero2;

            //Se pide el ingreso de una operacion
                do
                {
                    //Se pide elegir una operacion
                    Console.WriteLine("1.Sumar\n2.Restar\n3.Multiplicar\n4.Dividir\n\nElija una operacion: ");
                    ope = Convert.ToInt32(Console.ReadLine());

                } while (ope < 1 || ope > 4);

                //Se piden dos numeros
                Console.WriteLine("Ingrese un numero: ");
                numero1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Ingrese otro numero: ");
                numero2 = Convert.ToDouble(Console.ReadLine());

                //Se opera de acuerdo a la operacion elegida
                if (ope == 1)
                {
                    resultado = numero1 + numero2;
                    Console.WriteLine("La suma de " + numero1 + " y de " + numero2 + " es igual a: " + resultado);
                }
                if (ope == 2)
                {
                    resultado = numero1 - numero2;
                    Console.WriteLine("La resta de " + numero1 + " y de " + numero2 + " es igual a: " + resultado);
                }
                if (ope == 3)
                {
                    resultado = numero1 * numero2;
                    Console.WriteLine("La multiplicacion de " + numero1 + " y de " + numero2 + " es igual a: " + resultado);
                }
                if (ope == 4)
                {
                    if (numero2 != 0)
                    {
                        resultado = numero1 / numero2;
                        Console.WriteLine("La division de " + numero1 + " y de " + numero2 + " es igual a: " + resultado);
                    }
                    else
                    {
                        Console.WriteLine("\nERROR! No se puede dividir con cero!");
                        resultado = 0;
                    }
                }
        }
    }
}
