using System;
using System.Collections.Generic;
using System.Text;

namespace M5_Exercici_Jobs.Clases
{
    class Mid
    {
        //  TIENE UNA REDUCCION DEL 10% DEL SUELDO MENSUAL
        //  TIENE QUE COBRAR ENTRE 1800 Y 2500€
        public void calcMid()
        {
            //  PEDIMOS DATOS DEL MID
            Console.WriteLine("Cual es el nombre del Mid?");
            string nomMid = Console.ReadLine();
            Console.WriteLine("Cual es el sueldo mensual del Mid?");
            double sueldoMid = double.Parse(Console.ReadLine());
            Console.WriteLine("");

            //  CALCULAMOS EL PLUS SALARIAL DEL MID
            double calcsueldoMid = sueldoMid * 10 / 100;
            double sueldoFinMid = sueldoMid - calcsueldoMid;
            Console.WriteLine("El sueldo final mensual de " + nomMid + " es de: " + sueldoFinMid + "eur");

            //  AÑADIMOS SUELDO MINIMO Y MAXIMO
            if (sueldoFinMid > 2500 || sueldoFinMid < 1800)
            { throw new Exception("El Mid tiene que cobrar entre 1800 y 2500"); }

            //  CALCULAMOS EL SUELDO LIMPIO Y SUCIO ANUAL -- IRPF DEL 15%
            double calcSueldoAnualMid = sueldoFinMid * 12;
            double calcSueldoLimpioMid = calcSueldoAnualMid * 15 / 100;
            double sueldoLimpioMid = calcSueldoAnualMid - calcSueldoLimpioMid;
            Console.WriteLine("El sueldo limpio anual de " + nomMid + " es de: " + sueldoLimpioMid + "eur");

        }

    }
}
