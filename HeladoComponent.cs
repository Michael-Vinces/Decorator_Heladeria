using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator_Heladería
{
    // Clase Abtracta
    public abstract class HeladoComponent
    {
        // Propiedades abstractas que solo reciben el parametro
        public abstract double Costo { get; } // Precio
        public abstract string Descripcion { get; } // Detalle del producto
    }
}
