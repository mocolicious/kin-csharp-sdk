using System;
using System.Collections.Generic;
using System.Text;

namespace Kin.Base.models
{
    sealed class AccountSpec
    {
        public static AccountSpec Exact = new AccountSpec(0);
        public static AccountSpec Preferred = new AccountSpec(1);
        private AccountSpec(int value)
        {

        }
    }
}
