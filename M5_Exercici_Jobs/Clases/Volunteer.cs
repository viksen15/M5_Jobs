using System;
using System.Collections.Generic;
using System.Text;

namespace M5_Exercici_Jobs.Clases
{
    class Volunteer
    {
        //  NO COBREN
        public void calcVolunteer()
        {
            Console.WriteLine("Cual es el nombre del Volunteer?");
            string nomVolunteer = Console.ReadLine();
            Console.WriteLine(nomVolunteer + " no cobra.");
        }

    }
}
