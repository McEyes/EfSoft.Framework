using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Efsoft.Core
{
    public interface IProviderContext : IProviderContext<object>
    {
    }

    public interface IProviderContext<T> : IContext<T>
    {
    }
}
