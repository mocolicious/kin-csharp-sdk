// Automatically generated by xdrgen
// DO NOT EDIT or your changes may be overwritten
using System;

namespace Kin.Stellar.Sdk.xdr
{

    // === xdr source ============================================================

    //  typedef unsigned int uint32;

    //  ===========================================================================
    public class Uint32
    {
        public int InnerValue { get; set; } = default(int);

        public Uint32() { }

        public Uint32(int value)
        {
            InnerValue = value;
        }

        public static void Encode(XdrDataOutputStream stream, Uint32 encodedUint32)
        {
            stream.WriteInt(encodedUint32.InnerValue);
        }
        public static Uint32 Decode(XdrDataInputStream stream)
        {
            Uint32 decodedUint32 = new Uint32();
            decodedUint32.InnerValue = stream.ReadInt();
            return decodedUint32;
        }
    }
}
