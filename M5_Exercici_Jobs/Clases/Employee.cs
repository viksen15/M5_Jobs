using System;
using System.Collections.Generic;
using System.Text;

namespace M5_Exercici_Jobs.Clases
{
    class Employee
    {

        //  COBREN UN 15% MENOS DEL SEU SALARI MENSUAL
        public void calcEmployee()
        {
            Console.WriteLine("Cual es el nombre del Employee?");
            string nomEmployee = Console.ReadLine();
            Console.WriteLine("Cual es el sueldo mensual del Employee?");
            double sueldoEmployee = double.Parse(Console.ReadLine());
            Console.WriteLine("");
            //  CALCULAMOS EL PLUS SALARIAL DEL MANAGER
            double calcsueldoEmployee = sueldoEmployee * 15 / 100;
            double sueldoFinEmployee = sueldoEmployee - calcsueldoEmployee;
            Console.WriteLine("El sueldo final de " + nomEmployee + " es de: " + sueldoFinEmployee + "eur");
        }
    }
}
