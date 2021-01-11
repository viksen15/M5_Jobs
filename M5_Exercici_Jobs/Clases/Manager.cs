using System;
using System.Collections.Generic;
using System.Text;

namespace M5_Exercici_Jobs.Clases
{
    class Manager
    {
        //  TIENE QUE COBRAR ENTRE 3000 Y 5000€
        //  COBREN UN 10% MES DEL SEU SALARI MENSUAL
        public void calcMan()
        {   //  PEDIMOS DATOS DEL MANAGER
            Console.WriteLine("Cual es el nombre del Manager?");
            string nomMan = Console.ReadLine();
            Console.WriteLine("Cual es el sueldo mensual del Manager?");
            double sueldoMan = double.Parse(Console.ReadLine());
            Console.WriteLine("");

            //  CALCULAMOS EL PLUS SALARIAL DEL MANAGER
            double calcsueldoMan = sueldoMan * 10 / 100;
            double sueldoFinMan = sueldoMan + calcsueldoMan;
            Console.WriteLine("El sueldo final mensual de " + nomMan + " es de: " + sueldoFinMan + "eur");

            //  AÑADIMOS EL SUELDO MINIMO Y MAXIMO
            if (sueldoFinMan > 5000 || sueldoFinMan < 3000)
            { throw new Exception("El manager tiene que cobrar entre 3000 y 5000"); }

            //  CALCULAMOS EL SUELDO LIMPIO Y SUCIO ANUAL -- IRPF DEL 26%
            double calcSueldoAnualMan = sueldoFinMan * 12;
            double calcSueldoLimpioMan = calcSueldoAnualMan * 26 / 100;
            double sueldoLimpioMan = calcSueldoAnualMan - calcSueldoLimpioMan;
            Console.WriteLine("El sueldo limpio anual de " + nomMan + " es de: " + sueldoLimpioMan + "eur");
        }
    }

}
