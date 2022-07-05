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
            // Tipo string
            string[] cadenas = new string[5];
            cadenas[0] = "Henry";
            cadenas[1] = "Henry_1";
            cadenas[2] = "Henry_2";
            cadenas[3] = "Henry_3";
            cadenas[4] = "Henry_4";
            string[] name = { "pedrito" };

            Console.WriteLine("Length", cadenas.Length);
            Console.WriteLine(cadenas[0]);
            Console.WriteLine(name[0]);

            // Tipo int
            int[] age = new int[5];
            int[] numbers = { 1, 2, 3, 4, 5 };

            age[0] = 1;
            age[1] = 2;
            age[2] = 3;
            age[3] = 4;
            age[4] = 5;

            Console.WriteLine("Edad ", age[0]);

            // Arreglos mu
            Console.WriteLine("*******************************************");
            double[,] doble = new double[2, 2] { { 6, 3.7 }, { 6.3, 6.7 } };
            Console.WriteLine( doble[0,1]);


            Console.ReadLine();
        }
    }
}
