using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Introduzca una palabra");
            string palabra;
            palabra = Console.ReadLine();
            bool check = true;

            for (int i = 0; i < palabra.Length / 2; i++)
            {

                string letra1 = palabra.Substring(i, 1);
                string letra2 = palabra.Substring(palabra.Length - i - 1, 1);

                if (letra1 != letra2)
                {
                    check = false;
                }
                
            }
            
            if (check == true)
            {
                Console.WriteLine("Es un palindromo");
                    }
            else {
                Console.WriteLine("No es un palindromo");
                    }


            Console.Read();
        }
    }
}
