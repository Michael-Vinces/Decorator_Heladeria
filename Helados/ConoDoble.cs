﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator_Heladería
{
    public class ConoDoble:HeladoComponent
    {
        public override double Costo => 1.50;
        public override string Descripcion => "Cono Doble";
    }
}