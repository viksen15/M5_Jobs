﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M5_JOBS {
    class Boss : Empleado {        
        public Boss(double sueldoMensual) { 
            SueldoMensual = sueldoMensual;
            Multiplicador = 50;
        }        
    }
}
