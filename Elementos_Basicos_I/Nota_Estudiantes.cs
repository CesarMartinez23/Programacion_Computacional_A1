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
    class Nota_Estudiantes
    {
        static void Main(string[] args)
        {
            double Nota1, Nota2, Nota3, porcentaje1, porcentaje2, porcentaje3, sumaTotal;
            string nombre;

            Console.WriteLine("Ingrese el nombre del estudiante:");
            nombre = Console.ReadLine();

            Console.WriteLine();

            Console.WriteLine("Ingrese la primer nota del estudiante {0}:", nombre);
            Nota1 = double.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine("Ingrese la segunda nota del estudiante {0}:", nombre);
            Nota2 = double.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine("Ingrese la tercera nota del estudiante {0}:", nombre);
            Nota3 = double.Parse(Console.ReadLine());

            porcentaje1 = Nota1 * 0.30;

            porcentaje2 = Nota2 * 0.35;

            porcentaje3 = Nota3 * 0.25;

            sumaTotal = porcentaje1 + porcentaje2 + porcentaje3;

            Console.WriteLine();

            Console.WriteLine("Las notas ingresadas del alumno {0}, son: "+"Nota 1: "+Nota1+", Nota 2: "+Nota2 + ", Nota 3: "+Nota3, nombre);
            
            Console.WriteLine();

            Console.WriteLine("Las notas con el porcentaje aplicado son: "+ "30%: " + porcentaje1 + ", 35%: " + porcentaje2 + ", 25%: " + porcentaje3);

            Console.WriteLine();

            Console.WriteLine("La Nota Final es: " + sumaTotal);

            Console.ReadKey();
        }
        }
}
