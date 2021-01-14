using System;
using System.Collections.Generic;
using System.Text;

namespace NET_M6_EMPLEATS
{
    public class Base
    {
        private double SouBase { get; } = 2000;
        private double MultiplicadorSou { get; } = 1;
        private double MultiplicadorIRPF { get; } = 1;
        public double SouBrutMensual => SouBase * MultiplicadorSou;
        public double SouBrutAnual => SouBrutMensual * 12;
        public double SouNetMensual => SouBrutMensual * MultiplicadorIRPF;
        public double SouNetAnual => SouNetMensual * 12;
        public double bonus {get; set;}

        public Base(double souBase, double multiplicadorSou, double multiplicadorIRPF)
        {
            SouBase = souBase;
            MultiplicadorSou = multiplicadorSou;
            MultiplicadorIRPF = multiplicadorIRPF;
        }

        public override string ToString()
        {
            return $@"
                Sou Base: {SouBase}
                Sou Brut Mensual: {SouBrutMensual}
                Sou Brut Anual: {SouBrutAnual}
                Sou Net Mensual: {SouNetMensual}
                Sou Net Anual: {SouNetAnual}
            ";
        }

        public virtual void EmetreBonus()
        {
            Console.WriteLine($"Rep {SouNetAnual * 0.1} de bonus.");
            Console.WriteLine();
        }
    }
}
