using System;
using System.Collections.Generic;
using System.Text;

namespace TP6
{
    class Ej2
    {
        public void ejercicio2()
        {
            //VARIABLES
            string resp;
            int ope;
            double resultado = 0, numero1, numero2;

            //Se pide el ingreso de una operacion
            do
            {
                do
                {
                    //Se pide elegir una operacion
                    Console.Clear();
                    Console.WriteLine("1.Sumar\n2.Restar\n3.Multiplicar\n4.Dividir\n\nElija una operacion: ");
                    ope = Convert.ToInt32(Console.ReadLine());

                } while (ope < 1 || ope > 4);

                //Se piden dos numeros
                Console.Clear();
                Console.WriteLine("Ingrese un numero: ");
                numero1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Ingrese otro numero: ");
                numero2 = Convert.ToDouble(Console.ReadLine());

                //Se opera de acuerdo a la operacion elegida
                if (ope == 1)
                {
                    resultado = numero1 + numero2;
                }
                if (ope == 2)
                {
                    resultado = numero1 - numero2;
                }
                if (ope == 3)
                {
                    resultado = numero1 * numero2;
                }
                if (ope == 4)
                {
                    if(numero2 != 0)
                    {
                        resultado = numero1 / numero2;
                    }
                    else
                    {
                        Console.WriteLine("\nERROR! No se puede dividir con cero!");
                        resultado = 0;
                    }
                }
                
                //Se muestra resultado
                Console.WriteLine("Resultado: " + resultado);

                //Se pregunta si se quiere operar de nuevo
                Console.WriteLine("Desea realizar otra operacion? (S o N): ");
                resp = Console.ReadLine();

            } while (resp.ToLower() == "s");
        }
    }
}
