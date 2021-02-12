using Kin.Agora.Common.V3;
using Kin.Base.models;
using System;
using System.Collections.Generic;
using System.Text;
using TransactionHash = Kin.Agora.Common.V3.TransactionHash;

namespace Kin.Stellar.Sdk.models
{
    public interface KinTransaction
    {
        private readonly byte[] bytesValue;
        private readonly RecordType recordType;
        private readonly NetworkEnvironment networkEnvironment;
        private readonly Kin.Agora.Common.V3.InvoiceList invoiceList;
        private readonly TransactionHash transactionHash;
        private readonly Kin.Agora.Account.V4.Account signingSource;
        private readonly QuarkAmount fee;
        private readonly KinMemo kinMemo;
        private readonly List<KinOperation.Payment> paymentOperations;

        sealed class RecordType {
            private long timestamp;

            class InFlight
            {
                
            }

            class Acknowledged
            {

            }

            class Historical
            {

            }

        }
    }


}
