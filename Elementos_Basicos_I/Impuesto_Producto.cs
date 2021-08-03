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
    class Impuesto_Producto
    {
        static void Main(string[] args)
        {

            string producto;
            double precio, impuesto;
            int categoria;

            Console.WriteLine("Ingrese el nombre del producto:");
            producto =Console.ReadLine();

            Console.WriteLine();

            Console.WriteLine("Ingrese el precio del producto:");
            precio = double.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine("Seleccione la categoria del producto:");
            Console.WriteLine();
            Console.WriteLine("1-Alimentos");
            Console.WriteLine("2-Bebidas");
            Console.WriteLine("3-Textiles");
            Console.WriteLine("4-Electrodomesticos");
            Console.WriteLine("5-Medicina");
            Console.WriteLine("6-Otros");

            categoria = int.Parse(Console.ReadLine());

            if (categoria != 5)
            {
                impuesto = precio * 0.13;
                Console.WriteLine("El impuesto total del producto: {0} es $: "+ impuesto, producto);
            }
            else
            {
                Console.WriteLine("El impuesto total del producto: {0} es $: 0 ", producto);
            }

            Console.ReadKey();
        }
    }
}
