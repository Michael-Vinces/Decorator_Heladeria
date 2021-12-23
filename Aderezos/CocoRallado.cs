using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator_Heladería
{
    public class CocoRallado: AgregadoDecorator
    {
        public CocoRallado(HeladoComponent helado) : base(helado) { }
        public override double Costo => _helado.Costo + 0.15;
        public override string Descripcion => string.Format($"{_helado.Descripcion}\n - Coco Rallado");
    }
}
