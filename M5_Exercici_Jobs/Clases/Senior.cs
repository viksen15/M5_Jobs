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
            Console.WriteLine("Cual es el nombre del Senior?");
            string nomSenior = Console.ReadLine();
            Console.WriteLine("Cual es el sueldo mensual del Senior?");
            double sueldoSenior = double.Parse(Console.ReadLine());
            Console.WriteLine("");
            //  CALCULAMOS EL PLUS SALARIAL DEL MANAGER
            double calcsueldoSenior = sueldoSenior * 5 / 100;
            double sueldoFinSenior = sueldoSenior - calcsueldoSenior;
            Console.WriteLine("El sueldo final de " + nomSenior + " es de: " + sueldoFinSenior + "eur");
            //  AÑADIMOS SUELDO MINIMO Y MAXIMO
            if (sueldoFinSenior > 4000 || sueldoFinSenior < 2700)
            { throw new Exception("El sueldo del Senior tiene que ser entre 2700 y 4000"); }
        }

    }
}
