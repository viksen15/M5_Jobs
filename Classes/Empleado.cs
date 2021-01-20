using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M5_JOBS {
    class Empleado {
        private int _multiplicador;
        private int _irpf;
        private double _sueldoBase;
        private double _sueldoMensualBruto;
        private double _sueldoMensualNeto;
        private double _sueldoAnualBruto;
        private double _sueldoAnualNeto;

        public int Multiplicador {
            get => _multiplicador;
            set { _multiplicador = value; }
        }
        public double SueldoBase {
            get => _sueldoBase;
            set { _sueldoBase = value; }
        }
        public double SueldoMensualBruto {
            get => _sueldoMensualBruto;            
        }
        public double SueldoMensualNeto {
            get => _sueldoMensualNeto;            
        }
        public double SueldoAnualBruto {
            get => _sueldoAnualBruto;            
        }
        public double SueldoAnualNeto {
            get => _sueldoAnualNeto;            
        }
        public int IRPF {
            get => _irpf;
            set { _irpf = value; }
        }
        protected void setSueldoBruto() {
            _sueldoMensualBruto = SueldoBase * (1 + (Multiplicador / 100));
            _sueldoAnualBruto = _sueldoMensualBruto*14;
        }
        protected void setSueldoNeto() {
            _sueldoMensualNeto = SueldoBase * (1 + (Multiplicador / 100)) * (1 - (IRPF / 100));
            _sueldoAnualNeto = _sueldoMensualNeto * 14;
        }
    }
}