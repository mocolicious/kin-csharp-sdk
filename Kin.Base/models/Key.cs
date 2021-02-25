using Kin.Base.tools;
using Kin.Stellar.Sdk;
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
                return KeyPair.FromPublicKey(value).AccountId;
            }

            public string base58Encode()
            {
                return Base58.encode(value);
            }

            public bool verify(byte[] data, byte[] value)
            {
                return KeyPair.FromPublicKey(this.value).Verify(data, value);
            }

            public static byte[] decode(string _value)
            {
                return KeyPair.FromAccountId(_value).PublicKey;
            } 
        }

        public class PrivateKey
        {
            private byte[] value;
            public PrivateKey(string privateKeyString) 
            {
                value = Encoding.ASCII.GetBytes(KeyPair.FromSecretSeed(privateKeyString).SecretSeed);
            }

            public bool equals(object other)
            {
                if (this == other) return true;

                other = other as PrivateKey;
                if (!value.Equals(other)) return false;

                return true;
            }
            public int hashCode()
            {
                return value.GetHashCode();
            }

            public string toString()
            {
                return "Key.PrivateKey(value=XXXXXXXX<Private>XXXXXXXX)";
            }

            public string stellarBase32Encode()
            {
                return String.Format(KeyPair.FromSecretSeed(value).SecretSeed);
            }

            public string base58Encode()
            {
                return Base58.encode(value);
            }

            public byte[] sign(byte[] data)
            {
                return KeyPair.FromSecretSeed(value).Sign(data);
            }

            public static byte[] decode(string _value)
            {
                return KeyPair.FromAccountId(_value).PrivateKey;
            }

            public static PrivateKey random()
            {
                return new PrivateKey(KeyPair.Random().SecretSeed);
            }
        }
    }
}
