using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Efsoft.Core
{
    public abstract class ProviderContext : IProviderContext<ProviderContext>
    {

        public virtual ProviderContext Current
        {
            get { return this; }
        }
    }
}
