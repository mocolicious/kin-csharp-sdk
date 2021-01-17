using System;
using System.Collections.Generic;
using System.Text;

namespace Kin.Base.models.solana
{
    abstract class FixedByteArray
    {
        private int size { get; set; }
        FixedByteArray(byte[] byteArray) {
            size = byteArray.Length;
        }
    }
}
