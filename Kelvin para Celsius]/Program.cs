using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kelvin_para_Celsius_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Kelvin apara Grau Celsius 37 K − 273,15 

            double kelvin, celsius;

            Console.WriteLine("Transformar Kelvin para Grau Celsius.");
            Console.WriteLine("Formula: K − 273,15 = -236,1 °C\r\n");

            Console.Write("Digite Uma temperatura: ");
            kelvin = double.Parse(Console.ReadLine());

            celsius= kelvin - 273.15;

            Console.WriteLine($"Portanto, {kelvin} Kelvin equivalem a {celsius} graus Celsius.");

            Console.ReadKey();
            

        }
    }
}
