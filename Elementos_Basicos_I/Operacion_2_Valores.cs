using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Estudiantes:

//Cesar Jacob Martinez Alvarenga. Codigo: SMIS055621
//Yosselin Roxana Flores Garcia. Codigo: SMIS537818

namespace Elementos_Basicos_I
{
    class Operacion_2_Valores
    {
        static void Main(string[] args)
        {
            double a, b, c, d;
            Console.WriteLine("Ingrese el dato a:");
            a = double.Parse(Console.ReadLine());

            //Salto de Linea
            Console.WriteLine();

            Console.WriteLine("Ingrese el dato b:");
            b = double.Parse(Console.ReadLine());


            c = ((a + b) * (a - b));
            d = ((a * 2) - b);

            //Salto de Linea
            Console.WriteLine();

            Console.WriteLine("El resultado de (a + b) * (a - b) es igual a: " + c);

            //Salto de Linea
            Console.WriteLine();

            Console.WriteLine("El resultado de (a2-b) es igual a: " + d);

            Console.ReadKey();
    }
    }
}
