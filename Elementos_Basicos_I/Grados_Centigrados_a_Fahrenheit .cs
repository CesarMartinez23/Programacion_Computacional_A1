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
    class Grados_Centigrados_a_Fahrenheit
    {
        static void Main(string[] args)
        {
            double centigrados, faren;

            Console.WriteLine("Ingrese los grados centigrados");
            centigrados = double.Parse(Console.ReadLine());


            faren = (centigrados * 1.8) + 32;
            faren = (int)faren;
            

            Console.WriteLine("El resultado es igual a: "+ faren);

            Console.ReadKey();
        }
    }
}
