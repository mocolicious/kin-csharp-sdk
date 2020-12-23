using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Kin.Base_Compat
{
    public interface EventListener<T>
    {
        Task onEvent(T data);
    }
}
