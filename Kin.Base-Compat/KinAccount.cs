using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Kin.Base_Compat
{
    public interface KinAccount
    {
        Task<string> getPublicAddress();
        Task<string> getStringEncodedPrivateKey();
        Task<Transaction> buildTransaction(string publicAddress, decimal amount, int fee);
        Task<Transaction> buildTransaction(string publicAddress, decimal amount, int fee, string memo);
        Task<TransactionId> sendTransaction(Transaction transaction);
        Task<TransactionId> sendWhitelistTransaction(string whitelist);
        Task<Transaction> buildTransactionSync(string publicAddress, decimal amount, int fee);
        Task<Transaction> buildTransactionSync(string publicAddress, decimal amount, int fee, string memo);
        Task<TransactionId> sendTransactionSync(Transaction transaction);
        Task<TransactionId> sendWhitelistTransactionSync(string whitelist);
        Task<Balance> getBalance();
        Task<Balance> getBalanceSync();
        Task<int> getStatusSync();
        Task<int> getStatus();
        Task<ListenerRegistration> addBalanceListener(EventListener<Balance> listener);
        Task<ListenerRegistration> addPaymentListener(EventListener<PaymentInfo> listener);
        Task<ListenerRegistration> addAccountCreationListener(EventListener<Task> listener);
        Task<string> export(string passphrase);
    }
}
