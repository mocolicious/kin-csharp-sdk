using System;
using System.Collections.Generic;
using System.Text;

namespace Kin.Base_Compat
{
    public class Environment
    {
        private readonly string _networkUrl;
        private readonly string _networkPassphrase;
        private static readonly Network TEST = new Network() { networkPassphrase = "https://horizon-testnet.kininfrastructure.com/", networkUrl = "Kin Testnet ; December 2018" };
        private static readonly Network PRODUCTION = new Network() { networkPassphrase = "https://horizon.kinfederation.com", networkUrl = "Kin Mainnet ; December 2018" };
        public Environment(string networkUrl, string networkPassphrase)
        {
            _networkPassphrase = networkPassphrase;
            _networkUrl = networkUrl;
        }

        public class Network
        {
            public string networkPassphrase { get; set; }
            public string networkUrl { get; set; }
        }

        public static Environment Test()
        {
            return new Environment(TEST.networkPassphrase, TEST.networkUrl);
        }        
        
        public static Environment Production()
        {
            return new Environment(PRODUCTION.networkPassphrase, PRODUCTION.networkUrl);
        }

        public string networkPassphrase()
        {
            return _networkPassphrase;
        }

        public bool isMaintNet()
        {
            return PRODUCTION.networkPassphrase == _networkPassphrase;
        }
    }
}
