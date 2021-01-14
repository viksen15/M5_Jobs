using System;
using System.Collections.Generic;
using System.Text;

namespace NET_M6_EMPLEATS
{
    public class Employee : Base
    {
        public Employee(double souBase) : base(souBase, 0.85, 1) { }
        public Employee(double souBase, double multiplicadorSou, double multiplicadorIRPF)
            : base(souBase, multiplicadorSou, multiplicadorIRPF) { }
    }
}
