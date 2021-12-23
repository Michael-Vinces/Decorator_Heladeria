using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator_Heladería
{
    public class ConoSimple:HeladoComponent
    {
        public override double Costo => 0.99;
        public override string Descripcion => "Cono Simple";
    }
}
