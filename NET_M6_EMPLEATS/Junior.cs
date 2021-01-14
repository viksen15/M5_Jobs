using System;
using System.Collections.Generic;
using System.Text;

namespace NET_M6_EMPLEATS
{
    public class Junior : Employee
    {
        public Junior(double souBase): base(souBase, 0.85, 0.98)
        {
            if (souBase < 900 || souBase > 1600) throw new ArgumentOutOfRangeException(nameof(souBase));
        }

    }
}
