using System;
using System.Collections.Generic;
using System.Text;

namespace TP6
{
    class Ej5
    {
        public void ejercicio5()
        {
            string cadena;

            System.Text.RegularExpressions.Regex regex_web = new System.Text.RegularExpressions.Regex(@"^(www.|[a-zA-Z].)[a-zA-Z0-9\-\.]+\.(com|edu|gov|mil|net|org|biz|info|name|museum|us|ca|uk|ar)(\:[0-9]+)*(/($|[a-zA-Z0-9\.\,\;\?\'\\\+&amp;%\$#\=~_\-]+))*$");
            System.Text.RegularExpressions.Regex regex_email = new System.Text.RegularExpressions.Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Console.WriteLine("Ingrese una pagina web: ");
            cadena = Console.ReadLine();

            if(regex_web.IsMatch(cadena))
            {
                Console.WriteLine("Pagina correcta.");
            }
            else
            {
                Console.WriteLine("Pagina invalida.");
            }

            Console.WriteLine("\nIngrese un email: ");
            cadena = Console.ReadLine();

            if (regex_email.IsMatch(cadena))
            {
                Console.WriteLine("Email correcto.");
            }
            else
            {
                Console.WriteLine("Email invalido.");
            }
        }
    }
}
