using M5_Exercici_Jobs.Clases;
using System;

namespace M5_Exercici_Jobs
{
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
