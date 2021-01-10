using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Kin.Base_Compat
{
    public class ListenerRegistration
    {
        private readonly Task _removeListeneer;
        public ListenerRegistration(Task removeListener) 
        {
            _removeListeneer = removeListener;
        }

        public async Task removeListener()
        {
            await _removeListeneer.ConfigureAwait(false);
        }
    }
}
