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
            int valor1 = 9;
            int valor2 = 8;
            double valor3 = 10;
            double valor4 = 10;
            var data = valor1 != valor2;
            String name;
            //Estructura if y los operadores condicionales
            if (data)
            {
                Console.WriteLine("Uno "+data);
            }
            if (valor1 != valor2 || valor1 == valor2)
            {
                Console.WriteLine("Dos " +  data);
            }
            if (valor1 != valor2 && valor3 == valor4)
            {
                Console.WriteLine("Tres " + data);
            }
            //Estructura if y los operadores condicionales
            if (valor1 != valor2 && valor1 == valor2)
            {
                Console.WriteLine("Dos " + data);
            }
            else
            {
                Console.WriteLine("Else");
            }

            // Operador condicional
            name = data ? "Henry" : "Pedro";
            Console.WriteLine(name);

            var count = 1;
            Console.WriteLine(count);
            Console.WriteLine(count++);
            Console.ReadLine();
        }
    }
}
