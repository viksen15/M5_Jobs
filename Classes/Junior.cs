using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M5_JOBS {
    class Junior : Empleado {
        public Junior(double sueldoMensual) {
            try {
                comprobarSueldo(sueldoMensual);

                SueldoMensual = sueldoMensual;
            } catch (ArgumentOutOfRangeException ex) {
                Console.WriteLine(ex.Message);
            }

            Multiplicador = -15;
        }

        private void comprobarSueldo(double sueldo) {
            if ((sueldo <= 900) || sueldo >= 1600) throw new ArgumentOutOfRangeException(nameof(sueldo), "El sueldo debe oscilar entre 900 y 1600, el sueldo asignado será 0.");
        }
    }        
}
