using System;

namespace M5_Exercici_Jobs
{
    class Manager
    {
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
            Console.WriteLine("El sueldo final de " + nomMan + " es de: " + sueldoFinMan + "eur");
        }
    }
    class Boss
    {
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
        }

    }
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
    class Ejecutable
    {
        public void SeleccionEmpleado()
        {
            Ejecutable selEmpleados = new Ejecutable(); 
            int menu;
            Console.WriteLine("Que tipo de empleado es? \n1) Manager \n2) Boss \n3) Employee \n4) Volunteer");
            Console.WriteLine("");
            menu = Convert.ToInt32(Console.ReadLine());

            switch (menu)
            {
                case 1:
                    Console.WriteLine("Has seleccionado Manager");
                    Console.WriteLine("");
                    Manager manager = new Manager();
                    manager.calcMan();
                    break;

                case 2:
                    Console.WriteLine("Has seleccionado Boss");
                    Console.WriteLine("");
                    Boss boss = new Boss();
                    boss.calcBoss();
                    break;

                case 3:
                    Console.WriteLine("Has seleccionado Employee");
                    Console.WriteLine("");
                    Employee employee = new Employee();
                    employee.calcEmployee();
                    break;
                case 4:
                    Console.WriteLine("Has seleccionado Volunteer");
                    Console.WriteLine("");
                    Volunteer volunteer = new Volunteer();
                    volunteer.calcVolunteer();
                    break;
            }
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Ejecutable ejecutable = new Ejecutable();
            ejecutable.SeleccionEmpleado();


            Console.ReadKey();
        }
    }
}
