using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Kin.Base_Compat
{
    public interface PaymentInfo
    {
        Task<string> createdAt();
        Task<string> destinationPublicKey();
        Task<string> sourcePublicKey();
        Task<decimal> amount();
        Task<TransactionId> hash();
        Task<string> memo();
        Task<long> fee();
    }
}
