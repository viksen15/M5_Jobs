using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M5_JOBS {
    class Senior : Empleado {
        public Senior(double sueldoMensual) {
            try {
                comprobarSueldo(sueldoMensual);

                SueldoBase = sueldoMensual;
            } catch (ArgumentOutOfRangeException ex) {
                Console.WriteLine(ex.Message);
            }

            Multiplicador = -5;
            IRPF = 24;

            setSueldoBruto();
            setSueldoNeto();
        }

        private void comprobarSueldo(double sueldo) {
            if ((sueldo <= 2700) || sueldo >= 4000) throw new ArgumentOutOfRangeException(nameof(sueldo), "El sueldo debe oscilar entre 2700 y 4000, el sueldo asignado será 0.");
        }
    }
}
