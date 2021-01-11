using System;
using System.Collections.Generic;
using System.Text;

namespace M5_Exercici_Jobs.Clases
{
    class Junior
    {
        //  TIENE UNA REDUCCION DEL 15% DEL SUELDO MENSUAL
        //  TIENE QUE COBRAR ENTRE 900 Y 1600
        public void calcJunior()
        {
            //  PEDIMOS DATOS DEL JUNIOR
            Console.WriteLine("Cual es el nombre del Junior?");
            string nomJunior = Console.ReadLine();
            Console.WriteLine("Cual es el sueldo mensual del Junior?");
            double sueldoJunior = double.Parse(Console.ReadLine());
            Console.WriteLine("");

            //  CALCULAMOS EL PLUS SALARIAL DEL JUNIOR
            double calcsueldoJunior = sueldoJunior * 15 / 100;
            double sueldoFinJunior = sueldoJunior - calcsueldoJunior;
            Console.WriteLine("El sueldo final mensual de " + nomJunior + " es de: " + sueldoFinJunior + "eur");

            //  AÑADIMOS SUELDO MINIMO Y MAXIMO
            if (sueldoFinJunior > 1600 || sueldoFinJunior < 900)
            { throw new Exception("El Junior tiene que cobrar entre 900 y 1600"); }

            //  CALCULAMOS EL SUELDO LIMPIO Y SUCIO ANUAL -- IRPF DEL 2%
            double calcSueldoAnualJunior = sueldoFinJunior * 12;
            double calcSueldoLimpioJunior = calcSueldoAnualJunior * 2 / 100;
            double sueldoLimpioJunior = calcSueldoAnualJunior - calcSueldoLimpioJunior;
            Console.WriteLine("El sueldo limpio anual de " + nomJunior + " es de: " + sueldoLimpioJunior + "eur");
        }

    }
}
