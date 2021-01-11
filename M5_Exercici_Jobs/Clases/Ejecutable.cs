using System;
using System.Collections.Generic;
using System.Text;

namespace M5_Exercici_Jobs.Clases
{
    class Ejecutable
    {
        public void SeleccionEmpleado()
        {
            Ejecutable selEmpleados = new Ejecutable();
            int menu;
            Console.WriteLine("Que tipo de empleado es? \n1) Boss \n2) Manager \n3) Employee \n4) Senior \n5) Mid \n6) Junior \n7) Volunteer ");
            Console.WriteLine("");
            menu = Convert.ToInt32(Console.ReadLine());

            switch (menu)
            {
                case 1:
                    Console.WriteLine("Has seleccionado Boss");
                    Console.WriteLine("");
                    Boss boss = new Boss();
                    boss.calcBoss();
                    break;

                case 2:
                    Console.WriteLine("Has seleccionado Manager");
                    Console.WriteLine("");
                    Manager manager = new Manager();
                    manager.calcMan();
                    break;
                case 3:
                    Console.WriteLine("Has seleccionado Employee");
                    Console.WriteLine("");
                    Employee employee = new Employee();
                    employee.calcEmployee();
                    break;
                case 4:
                    Console.WriteLine("Has seleccionado Senior");
                    Console.WriteLine("");
                    Senior senior = new Senior();
                    senior.calcSenior();
                    break;
                case 5:
                    Console.WriteLine("Has seleccionado Mid");
                    Console.WriteLine("");
                    Mid mid = new Mid();
                    mid.calcMid();
                    break;
                case 6:
                    Console.WriteLine("Has seleccionado Junior");
                    Console.WriteLine("");
                    Junior junior = new Junior();
                    junior.calcJunior();
                    break;

                case 7:
                    Console.WriteLine("Has seleccionado Volunteer");
                    Console.WriteLine("");
                    Volunteer volunteer = new Volunteer();
                    volunteer.calcVolunteer();
                    volunteer.ajutGovern();
                    break;
            }
        }

    }

}
