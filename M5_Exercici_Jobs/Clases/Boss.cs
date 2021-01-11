using System;
using System.Collections.Generic;
using System.Text;

namespace M5_Exercici_Jobs.Clases
{
    class Boss
    {
        //  TIENE QUE COBRAR MAS DE 8000€
        //  COBREN UN 50% MES DEL SEU SALARI MENSUAL
        public void calcBoss()
        {
            Console.WriteLine("Cual es el nombre del Boss?");
            string nomBoss = Console.ReadLine();
            Console.WriteLine("Cual es el sueldo mensual del Boss?");
            double sueldoBoss = double.Parse(Console.ReadLine());
            Console.WriteLine("");
            //  CALCULAMOS EL PLUS SALARIAL DEL BOSS
            double calcsueldoBoss = sueldoBoss * 50 / 100;
            double sueldoFinBoss = sueldoBoss + calcsueldoBoss;
            Console.WriteLine("El sueldo final mensual de " + nomBoss + " es de: " + sueldoFinBoss + "eur");
            //  AÑADIMOS COBRO MINIMO CON EXCEPCION

            if (sueldoFinBoss < 8000) 
            { throw new Exception("Tiene que cobrar mas de 8000"); }

            //  CALCULAMOS EL SUELDO LIMPIO Y SUCIO ANUAL -- IRPF DEL 32%
            double calcSueldoAnualBoss = sueldoFinBoss * 12;
            double calcSueldoLimpioBoss = calcSueldoAnualBoss * 32 / 100;
            double sueldoLimpioBoss = calcSueldoAnualBoss - calcSueldoLimpioBoss;
            Console.WriteLine("El sueldo limpio anual de " + nomBoss + " es de: " + sueldoLimpioBoss + "eur");

        }
    }
}
