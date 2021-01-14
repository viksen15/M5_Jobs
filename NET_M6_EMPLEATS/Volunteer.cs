using System;
using System.Collections.Generic;
using System.Text;

namespace NET_M6_EMPLEATS
{
    public class Volunteer : Base
    {
        public double Ajuda { get; } = 0;
        public Volunteer(double ajuda) : base(0, 0, 0) {
            // El constructor de Volunteer no accepta sou base, pel que mai cobra.
            if (ajuda > 300) throw new ArgumentOutOfRangeException(nameof(ajuda));
            Ajuda = ajuda;
        }

        public override string ToString()
        {
            return base.ToString() + $"\tAjuda: {Ajuda}\n";
        }

        public override void EmetreBonus()
        {
            Console.WriteLine("Els voluntaris no reben bonus.");
        }
    }
}
