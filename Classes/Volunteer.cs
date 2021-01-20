using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M5_JOBS {
    class Volunteer : Empleado {
        
        public Volunteer(double sueldoMensual) {
            try {
                comprobarSueldo(sueldoMensual);

                SueldoBase = sueldoMensual;
            } catch (ArgumentOutOfRangeException ex) {
                Console.WriteLine(ex.Message);
            }

            Multiplicador = 0;
        }

        private void comprobarSueldo(double sueldo) {
            if ((sueldo != 0)) throw new ArgumentOutOfRangeException(nameof(sueldo), "Los voluntarios no cobran, el sueldo asignado será 0.");
        }
    }
}
