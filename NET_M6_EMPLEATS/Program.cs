using System;

namespace NET_M6_EMPLEATS
{
    class Program
    {
        static void Main(string[] args)
        {
            double souBase = 1000;

            Console.WriteLine($"Sou base: {souBase}");

            Base empleat = new Boss(souBase*8);
            Console.WriteLine("Boss:");
            Console.WriteLine(empleat);
            empleat.EmetreBonus();

            empleat = new Manager(souBase * 4);
            Console.WriteLine("Manager:");
            Console.WriteLine(empleat);
            empleat.EmetreBonus();

            empleat = new Senior(souBase * 3);
            Console.WriteLine("Senior:");
            Console.WriteLine(empleat);
            empleat.EmetreBonus();

            empleat = new Mid(souBase * 2);
            Console.WriteLine("Mid:");
            Console.WriteLine(empleat);
            empleat.EmetreBonus();

            empleat = new Junior(souBase);
            Console.WriteLine("Junior:");
            Console.WriteLine(empleat);
            empleat.EmetreBonus();

            empleat = new Volunteer(200);
            Console.WriteLine("Volunteer:");
            Console.WriteLine(empleat);
            empleat.EmetreBonus();
        }
    }
}
