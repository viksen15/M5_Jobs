using System;
using System.Collections.Generic;
using System.Text;

namespace NET_M6_EMPLEATS
{
    public class Senior : Employee
    {
        public Senior(double souBase) : base(souBase, 0.95, 0.76)
        {
            if (souBase < 2700 || souBase > 4000) throw new ArgumentOutOfRangeException(nameof(souBase));
        }
    }
}
