using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator_Heladería
{
    public class Gomitas:AgregadoDecorator
    {
        public Gomitas(HeladoComponent helado) : base(helado) { }
        public override double Costo => _helado.Costo + 0.35;
        public override string Descripcion => string.Format($"{_helado.Descripcion}\n - Gomitas");
    }
}
