using Kin.Stellar.Sdk;
using System;
using System.Collections.Generic;
using System.Text;

namespace Kin.Base_Compat
{
    public class Transaction
    {
        private readonly KinTransaction kinTransaction;
        public Transaction(
            KeyPair destination,
            KeyPair source,
            decimal amount,
            int fee,
            string memo
        )
        {
            
        }
    }
}
