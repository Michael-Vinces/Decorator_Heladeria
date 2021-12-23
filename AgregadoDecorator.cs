using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator_Heladería
{
    // Clase abstracta
    public abstract class AgregadoDecorator : HeladoComponent
    {
        protected HeladoComponent _helado; 
        public AgregadoDecorator(HeladoComponent helado)
        {
            _helado = helado;
        }
    }
}
