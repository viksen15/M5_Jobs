using System;
using System.Collections.Generic;
using System.Text;

namespace M5_Exercici_Jobs.Clases
{
    class Volunteer
    {
        private bool ajutVolunteer;
        public bool AjutVolunteer { set { this.ajutVolunteer = value; } get { return ajutVolunteer; } }
        private string nomVolunteer;
        public string NonVolunteer { set { this.nomVolunteer = value; } get { return nomVolunteer; } }
        //  NO COBREN
        public void calcVolunteer()
        {
            Console.WriteLine("Cual es el nombre del Volunteer?");
            nomVolunteer = Console.ReadLine();
            Console.WriteLine(nomVolunteer + " no cobra.");
            Console.WriteLine("");
            Console.WriteLine("Te ajut guvernamental?");
            ajutVolunteer = Convert.ToBoolean(Console.ReadLine());
        }
        public bool ajutGovern()
        {
            int ajut = 300;
            //  ES PREGUNTA SI COBRA L'AJUT GOVERNAMENTAL
            //  SI EL COBRA ES CALCULA EL SOU FINAL ANUAL
            if (ajutVolunteer == true)
            { 
                Console.WriteLine("El volunteer " + nomVolunteer + " cobra l'ajut.");
                Console.WriteLine("El sou final anual de " + nomVolunteer + " es de: " + ajut*12 + "eur.");
            }
            if (ajutVolunteer == false)
            { Console.WriteLine("No cobra."); }
            return ajutVolunteer;
        }

    }
}
