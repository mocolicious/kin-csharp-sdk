using Kin.Base.models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Kin.Stellar.Sdk.models
{
    public interface KinTransaction
    {
        private readonly byte[] bytesValue;
        private readonly RecordType recordType;
        private readonly NetworkEnvironment networkEnvironment;
        private readonly InvloiceList? invoiceList;
        private readonly TransactionHash transactionHash;
        private readonly KinAccount.Id signingSource;
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
