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
    class Operacion_2_Enteros
    {
        static void Main(string[] args)
        {
            int numero1, numero2;
            Console.WriteLine("Ingrese el primer numero entero: ");
            numero1 = int.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine("Ingrese el segundo numero entero: ");
            numero2 = int.Parse(Console.ReadLine());

            if (numero2 != 0)
            {
                Console.WriteLine("La division efectuada de {0} / {1} es: "+numero1 / numero2, numero1,numero2);
            }
            else
            {
                Console.WriteLine("¡Error, no se puede dividir entre cero!");
            }
                Console.ReadKey();
            }
        } 
    }
