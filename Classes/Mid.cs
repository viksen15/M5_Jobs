using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M5_JOBS {
    class Mid : Empleado {
        public Mid(double sueldoMensual) {
            try {
                comprobarSueldo(sueldoMensual);

                SueldoBase = sueldoMensual;
            } catch (ArgumentOutOfRangeException ex) {
                Console.WriteLine(ex.Message);
            }

            Multiplicador = -10;
            IRPF = 15;

            setSueldoBruto();
            setSueldoNeto();
        }

        private void comprobarSueldo(double sueldo) {
            if ((sueldo <= 1800) || sueldo >= 2500) throw new ArgumentOutOfRangeException(nameof(sueldo), "El sueldo debe oscilar entre 1800 y 2500, el sueldo asignado será 0.");
        }
    }
    }
}
