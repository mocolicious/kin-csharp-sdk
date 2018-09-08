// Automatically generated by xdrgen
// DO NOT EDIT or your changes may be overwritten

namespace stellar_dotnet_sdk.xdr
{
// === xdr source ============================================================

//  struct TransactionResult
//  {
//      int64 feeCharged; // actual fee charged for the transaction
//  
//      union switch (TransactionResultCode code)
//      {
//      case txSUCCESS:
//      case txFAILED:
//          OperationResult results<>;
//      default:
//          void;
//      }
//      result;
//  
//      // reserved for future use
//      union switch (int v)
//      {
//      case 0:
//          void;
//      }
//      ext;
//  };

//  ===========================================================================
    public class TransactionResult
    {
        public Int64 FeeCharged { get; set; }
        public TransactionResultResult Result { get; set; }
        public TransactionResultExt Ext { get; set; }

        public static void Encode(XdrDataOutputStream stream, TransactionResult encodedTransactionResult)
        {
            Int64.Encode(stream, encodedTransactionResult.FeeCharged);
            TransactionResultResult.Encode(stream, encodedTransactionResult.Result);
            TransactionResultExt.Encode(stream, encodedTransactionResult.Ext);
        }

        public static TransactionResult Decode(XdrDataInputStream stream)
        {
            var decodedTransactionResult = new TransactionResult();
            decodedTransactionResult.FeeCharged = Int64.Decode(stream);
            decodedTransactionResult.Result = TransactionResultResult.Decode(stream);
            decodedTransactionResult.Ext = TransactionResultExt.Decode(stream);
            return decodedTransactionResult;
        }

        public class TransactionResultResult
        {
            public TransactionResultCode Discriminant { get; set; } = new TransactionResultCode();

            public OperationResult[] Results { get; set; }

            public static void Encode(XdrDataOutputStream stream, TransactionResultResult encodedTransactionResultResult)
            {
                stream.WriteInt((int) encodedTransactionResultResult.Discriminant.InnerValue);
                switch (encodedTransactionResultResult.Discriminant.InnerValue)
                {
                    case TransactionResultCode.TransactionResultCodeEnum.txSUCCESS:
                    case TransactionResultCode.TransactionResultCodeEnum.txFAILED:
                        var resultssize = encodedTransactionResultResult.Results.Length;
                        stream.WriteInt(resultssize);
                        for (var i = 0; i < resultssize; i++) OperationResult.Encode(stream, encodedTransactionResultResult.Results[i]);
                        break;
                    default:
                        break;
                }
            }

            public static TransactionResultResult Decode(XdrDataInputStream stream)
            {
                var decodedTransactionResultResult = new TransactionResultResult();
                var discriminant = TransactionResultCode.Decode(stream);
                decodedTransactionResultResult.Discriminant = discriminant;
                switch (decodedTransactionResultResult.Discriminant.InnerValue)
                {
                    case TransactionResultCode.TransactionResultCodeEnum.txSUCCESS:
                    case TransactionResultCode.TransactionResultCodeEnum.txFAILED:
                        var resultssize = stream.ReadInt();
                        decodedTransactionResultResult.Results = new OperationResult[resultssize];
                        for (var i = 0; i < resultssize; i++) decodedTransactionResultResult.Results[i] = OperationResult.Decode(stream);
                        break;
                    default:
                        break;
                }
                return decodedTransactionResultResult;
            }
        }

        public class TransactionResultExt
        {
            public int Discriminant { get; set; }

            public static void Encode(XdrDataOutputStream stream, TransactionResultExt encodedTransactionResultExt)
            {
                stream.WriteInt(encodedTransactionResultExt.Discriminant);
                switch (encodedTransactionResultExt.Discriminant)
                {
                    case 0:
                        break;
                }
            }

            public static TransactionResultExt Decode(XdrDataInputStream stream)
            {
                var decodedTransactionResultExt = new TransactionResultExt();
                var discriminant = stream.ReadInt();
                decodedTransactionResultExt.Discriminant = discriminant;
                switch (decodedTransactionResultExt.Discriminant)
                {
                    case 0:
                        break;
                }
                return decodedTransactionResultExt;
            }
        }
    }
}