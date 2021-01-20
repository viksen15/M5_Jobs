using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M5_JOBS {
    class Manager : Empleado {
        public Manager(double sueldoMensual) {
            try {
                comprobarSueldo(sueldoMensual);

                SueldoMensual = sueldoMensual;
            } catch (ArgumentOutOfRangeException ex) {
                Console.WriteLine(ex.Message);
            }

            Multiplicador = 10;
        }

        private void comprobarSueldo(double sueldo) {
            if ((sueldo <= 3000) || sueldo>=5000) throw new ArgumentOutOfRangeException(nameof(sueldo), "El sueldo debe oscilar entre 3000 y 5000, el sueldo asignado será 0.");
        }
    }
}
