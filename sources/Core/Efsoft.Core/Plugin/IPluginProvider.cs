using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Efsoft.Core.Plugin
{
    /// <summary>
    /// 
    /// </summary>
    public interface IPluginProvider : IPluginProvider<IPlugin>
    {
    }
    /// <summary>
    /// 
    /// </summary>
    public interface IPluginProvider<T> : IProvider<T>
    {
    }
}
