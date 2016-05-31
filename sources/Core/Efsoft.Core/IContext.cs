using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Efsoft.Core
{

    public abstract class Context : IContext<Context>
    {
        public Context Current { get { return this; } }
    }

    public interface IContext:IContext<object>
    {
        object Context { get; }
    }

    public interface IContext<T>
    {
        T Current { get; }
    }
}
