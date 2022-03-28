using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volumen_cilindro
{
    class Program
    {
        static void Main(string[] args)
        {


            double  pi, radio, altura, resultado;

            pi = 3.141592653589793;


            Console.Title = "Volumen del cilindro";

            Console.WriteLine(" Introduzca el valor del radio del cilindro, y su altura");

            Console.WriteLine("Radio");
            radio = double.Parse(Console.ReadLine());

            Console.WriteLine("Altura");
            altura = double.Parse(Console.ReadLine());

            resultado = (pi * radio * radio * altura);

            Console.WriteLine(" La solucion es : {0}", resultado);


            Console.ReadKey();
        }
    }
}
