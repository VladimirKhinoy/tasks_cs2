﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation.Valeriya
{
    class Double: Number<double>
    {
        double Add(double oper)
        {
            return oper + value;
        }

    }
}
