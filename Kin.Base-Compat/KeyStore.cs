using Kin.Stellar.Sdk;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Kin.Base_Compat
{
    interface KeyStore
    {
        Task<List<KeyPair>> loadAccounts();
        Task deleteAccount(string publicAddress);
        Task<KeyPair> newAccount();
        Task<KeyPair> importAccount(string json, string passphrase);
        Task clearAllAccounts();
    }
}
