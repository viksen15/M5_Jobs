using System;
using System.Collections.Generic;
using System.Text;

namespace M5_Exercici_Jobs.Clases
{
    class Senior
    {
        //  TIENE UNA REDUCCION DEL 5% DEL SUELDO MENSUAL
        //  TIENE QUE COBRAR ENTRE 2700 Y 4000€
        public void calcSenior()
        {
            //  PEDIMOS LOS DATOS DEL SENIOR
            Console.WriteLine("Cual es el nombre del Senior?");
            string nomSenior = Console.ReadLine();
            Console.WriteLine("Cual es el sueldo mensual del Senior?");
            double sueldoSenior = double.Parse(Console.ReadLine());
            Console.WriteLine("");

            //  CALCULAMOS LA REDUCCION SALARIAL DEL SENIOR
            double calcsueldoSenior = sueldoSenior * 5 / 100;
            double sueldoFinSenior = sueldoSenior - calcsueldoSenior;
            Console.WriteLine("El sueldo final de " + nomSenior + " es de: " + sueldoFinSenior + "eur");

            //  AÑADIMOS SUELDO MINIMO Y MAXIMO
            if (sueldoFinSenior > 4000 || sueldoFinSenior < 2700)
            { throw new Exception("El sueldo del senior tiene que ser entre 2700 y 4000"); }

            //  CALCULAMOS EL SUELDO LIMPIO Y SUCIO ANUAL -- IRPF DEL 24%
            double calcSueldoAnualSenior = sueldoFinSenior * 12;
            double calcSueldoLimpioSenior = calcSueldoAnualSenior * 24 / 100;
            double sueldoLimpioSenior = calcSueldoAnualSenior - calcSueldoLimpioSenior;
            Console.WriteLine("El sueldo limpio anual de " + nomSenior + " es de: " + sueldoLimpioSenior + "eur");
        }

    }
}
