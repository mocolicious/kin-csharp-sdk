using System;
using System.Collections.Generic;
using System.Text;

namespace Kin.Base.models
{
    sealed class Key
    {
        static byte[] value;
        public class PublicKey 
        {
            public PublicKey(string publicKeyString)
            {  
            }

            public bool equals(object other)
            {
                if (this == other) return true;

                return true;
            }

            public override int hashCode()
            {
                return value.GetHashCode();
            }
        }

        public class PrivateKey
        {
            public PrivateKey() { }
        }
    }
}
