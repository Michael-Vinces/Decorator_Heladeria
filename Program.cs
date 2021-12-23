using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator_Heladería
{
    class Program
    {
        static void Main(string[] args)
        {
            //  Tipos de Helados          Aderezos
            //
            //    Cono Simple             Gomitas
            //     Cono Doble        Chips de Chocolate
            //    Cono Triple           Coco Rallado
            //    Banana Split           Almendras

            HeladoComponent consumible =new BananaSplit();
            consumible = new CocoRallado(consumible);
            consumible = new CocoRallado(consumible);
            consumible = new Almendras(consumible);

            //HeladoComponent consumible1 = new ConoDoble();
            //consumible1 = new ChipsChocolate(consumible1);


            Console.WriteLine($"Producto:\n{consumible.Descripcion} \nEl costo de su Helado es: ${consumible.Costo}\n");
            //Console.WriteLine($"Producto: \n{consumible1.Descripcion} \nEl costo de su Helado es: ${consumible1.Costo}");
            Console.ReadKey();
        }
    }
}
