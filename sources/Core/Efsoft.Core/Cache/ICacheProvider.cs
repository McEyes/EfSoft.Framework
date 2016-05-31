using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Efsoft.Core.Cache
{
    /// <summary>
    /// 
    /// </summary>
    public interface ICacheProvider<T> : IProvider<T>
    {
      
    }

    /// <summary>
    /// 
    /// </summary>
    public interface ICacheProvider : ICacheProvider<ICache>
    {

    }
}
