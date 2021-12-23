using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator_Heladería
{
    public class Almendras: AgregadoDecorator
    {
        public Almendras(HeladoComponent helado) : base(helado) { }
        public override double Costo => _helado.Costo + 0.30; // Agrega al costo calculado previamente el valor de Almendras
        public override string Descripcion => string.Format($"{_helado.Descripcion}\n - Almendras");
    }
}
