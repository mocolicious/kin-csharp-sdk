using System;
using System.Collections.Generic;
using System.Text;

namespace Kin.Base.models.solana
{
    public class Transaction
    {
    }

    public class Signature
    {
    }

    public class Hash
    {
    }

    public class Header
    {
    }

    public class Message
    {
        public Header _header;
        public List<Key.PublicKey> _accounts;
        public List<CompiledInstruction> _instructions;
        public Hash _recentBlockHash;
        public Message(
            Header header, 
            List<Key.PublicKey> accounts, 
            List<CompiledInstruction> instructions, 
            Hash recentBlockHash
        )
        {
            _header = header;
            _accounts = accounts;
            _instructions = instructions;
            _recentBlockHash = recentBlockHash;
        }
    }
}
