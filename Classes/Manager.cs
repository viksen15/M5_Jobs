using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M5_JOBS {
    class Manager : Empleado {
        public Manager(double sueldoMensual) {
            SueldoMensual = sueldoMensual;
            Multiplicador = 10;
        }
    }
}
