using Kin.Base.tools;
using System;
using System.Collections.Generic;
using System.Text;

namespace Kin.Base.models
{
    sealed class Key
    {
        //public byte[] value;
        public class PublicKey
        {
            private byte[] value;

            public PublicKey(string publicKeyString)
            {  
            }

            public bool equals(object other)
            {
                if (this == other) return true;

                return true;
            }

            public int hashCode()
            {
                return value.GetHashCode();
            }

            public string toString()
            {
                return String.Format("Key.PublicKey(value={0}, b58={1})", stellarBase32Encode(), base58Encode());
            }

            public string stellarBase32Encode()
            {
                return toKeyPair().accountId;
            }

            public string base58Encode()
            {
                return Base58.encode(value);
            }
        }

        public class PrivateKey
        {
            public PrivateKey() { }
        }
    }
}
