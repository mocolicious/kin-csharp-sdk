using Kin.Stellar.Sdk;
using System.Threading.Tasks;

namespace Kin.Base_Compat
{
    public interface BackupRestore
    {
        Task<string> exportWallet(KeyPair keyPair, string passphrase);
        Task<KeyPair> importWallet(string exportedJson, string passphrase);
    }
}
