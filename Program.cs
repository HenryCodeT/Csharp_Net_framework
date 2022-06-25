using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int year = Convert.ToInt16("12");
            double decimales = 2.3;
            string nombre = "henry";
            string nombres = "pedro vasquez";
            decimal decimals = 2.07m;
            float flotante = 8.9f;
            bool booleano = false;
            char caracter = 'R';
            Decimal decimal1 = 24.5m;

            Console.WriteLine(nombres +" Hello Henry {0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}", year, decimales, nombre, decimals, flotante, booleano, caracter, decimal1);
            
            Console.ReadLine();
        }
        // float 7 digitos 32 bits
        // double 15-16 digitos 64 bits
        // decimal 28-29 digitos 128 bits
    }
}
