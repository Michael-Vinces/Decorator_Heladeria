using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator_Heladería
{
    public abstract class AgregadoDecorator : HeladoComponent
    {
        protected HeladoComponent _helado; 
        public AgregadoDecorator(HeladoComponent helado)
        {
            _helado = helado;
        }
    }
}
