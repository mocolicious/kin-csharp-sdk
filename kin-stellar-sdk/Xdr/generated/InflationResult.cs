// Automatically generated by xdrgen
// DO NOT EDIT or your changes may be overwritten
using System;

namespace Kin.Stellar.Sdk.xdr
{

    // === xdr source ============================================================

    //  union InflationResult switch (InflationResultCode code)
    //  {
    //  case INFLATION_SUCCESS:
    //      InflationPayout payouts<>;
    //  default:
    //      void;
    //  };

    //  ===========================================================================
    public class InflationResult
    {
        public InflationResult() { }

        public InflationResultCode Discriminant { get; set; } = new InflationResultCode();

        public InflationPayout[] Payouts { get; set; }
        public static void Encode(XdrDataOutputStream stream, InflationResult encodedInflationResult)
        {
            stream.WriteInt((int)encodedInflationResult.Discriminant.InnerValue);
            switch (encodedInflationResult.Discriminant.InnerValue)
            {
                case InflationResultCode.InflationResultCodeEnum.INFLATION_SUCCESS:
                    int payoutssize = encodedInflationResult.Payouts.Length;
                    stream.WriteInt(payoutssize);
                    for (int i = 0; i < payoutssize; i++)
                    {
                        InflationPayout.Encode(stream, encodedInflationResult.Payouts[i]);
                    }
                    break;
                default:
                    break;
            }
        }
        public static InflationResult Decode(XdrDataInputStream stream)
        {
            InflationResult decodedInflationResult = new InflationResult();
            InflationResultCode discriminant = InflationResultCode.Decode(stream);
            decodedInflationResult.Discriminant = discriminant;
            switch (decodedInflationResult.Discriminant.InnerValue)
            {
                case InflationResultCode.InflationResultCodeEnum.INFLATION_SUCCESS:
                    int payoutssize = stream.ReadInt();
                    decodedInflationResult.Payouts = new InflationPayout[payoutssize];
                    for (int i = 0; i < payoutssize; i++)
                    {
                        decodedInflationResult.Payouts[i] = InflationPayout.Decode(stream);
                    }
                    break;
                default:
                    break;
            }
            return decodedInflationResult;
        }
    }
}
