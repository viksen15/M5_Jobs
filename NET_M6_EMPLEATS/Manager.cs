using System;
using System.Collections.Generic;
using System.Text;

namespace NET_M6_EMPLEATS
{
    public class Manager : Base
    {
        public Manager(double souBase) : base(souBase, 1.1, 0.74)
        {
            if (souBase < 3000 || souBase > 5000) throw new ArgumentOutOfRangeException(nameof(souBase));
        }
    }
}
