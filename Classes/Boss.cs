using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M5_JOBS {
    class Boss : Empleado {        
        public Boss(double sueldoMensual) {
            try {
                comprobarSueldo(sueldoMensual);

                SueldoBase = sueldoMensual;
            } catch (ArgumentOutOfRangeException ex) {
                Console.WriteLine(ex.Message);
            }

            Multiplicador = 50;
            IRPF = 32;

            setSueldoBruto();
            setSueldoNeto();
        }

        private void comprobarSueldo(double sueldo) {
            if (sueldo <= 8000) throw new ArgumentOutOfRangeException(nameof(sueldo), "El sueldo debe ser superior a 8000, el sueldo asignado será 0.");
        }
    }
}
