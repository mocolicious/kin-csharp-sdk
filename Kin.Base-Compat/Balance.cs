﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Kin.Base_Compat
{
    public interface Balance
    {
        Task<decimal> value();
        Task<string> value(int precision);
    }
}
