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
            //  CALCULAMOS EL PLUS SALARIAL DEL MANAGER
            double calcsueldoBoss = sueldoBoss * 50 / 100;
            double sueldoFinBoss = sueldoBoss + calcsueldoBoss;
            Console.WriteLine("El sueldo final de " + nomBoss + " es de: " + sueldoFinBoss + "eur");
            //  AÑADIMOS COBRO MINIMO CON EXCEPCION

            if (sueldoFinBoss < 8000) ;
            {
                throw new Exception("Tiene que cobrar mas de 8000");
            }

        }
    }
}
