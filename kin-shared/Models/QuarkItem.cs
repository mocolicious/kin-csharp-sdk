using System;
using System.Collections.Generic;
using System.Text;

namespace Kin.Base.models
{
    public class QuarkItem
    {
        public QuarkItem() { }
    }

    public class QuarkAmount
    {
        private static readonly long QUARK_CONVERSION_RATE = 100000;
        private readonly long _value;
        public QuarkAmount(long value) {
            _value = value;
        }

        public long toKin()
        {
            return _value / QUARK_CONVERSION_RATE;
        }
    }
}
