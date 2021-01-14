using System;
using System.Collections.Generic;
using System.Text;

namespace NET_M6_EMPLEATS
{
    public class Mid : Employee
    {
        public Mid(double souBase) : base(souBase, 0.90, 0.85)
        {
            if (souBase < 1800 || souBase > 2500) throw new ArgumentOutOfRangeException(nameof(souBase));
        }
    }
}
