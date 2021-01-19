using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M5_JOBS {
    class Empleado {
        private int _multiplicador;
        private double _sueldoMensual;
        public int Multiplicador {
            get => _multiplicador;
            set { _multiplicador = value; }
        }
        public double SueldoMensual {
            get => _sueldoMensual;
            set { _sueldoMensual = value; }
        }        
        public double getSueldoNeto () {
            return SueldoMensual * (1 + (Multiplicador / 100));
        }
    }
}
