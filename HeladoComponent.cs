using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator_Heladería
{
    public abstract class HeladoComponent
    {
        public abstract double Costo { get; }
        public abstract string Descripcion { get; }
    }
}
