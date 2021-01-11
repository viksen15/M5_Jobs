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
            Console.WriteLine("Cual es el nombre del Junior?");
            string nomJunior = Console.ReadLine();
            Console.WriteLine("Cual es el sueldo mensual del Junior?");
            double sueldoJunior = double.Parse(Console.ReadLine());
            Console.WriteLine("");
            //  CALCULAMOS EL PLUS SALARIAL DEL MANAGER
            double calcsueldoJunior = sueldoJunior * 15 / 100;
            double sueldoFinJunior = sueldoJunior - calcsueldoJunior;
            Console.WriteLine("El sueldo final de " + nomJunior + " es de: " + sueldoFinJunior + "eur");
            //  AÑADIMOS SUELDO MINIMO Y MAXIMO
            if (sueldoFinJunior > 1600 || sueldoFinJunior < 900)
            { throw new Exception("El Junior tiene que cobrar entre 900 y 1600"); }
        }

    }
}
