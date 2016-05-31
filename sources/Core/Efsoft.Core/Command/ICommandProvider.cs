using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Efsoft.Core.Command
{
    /// <summary>
    /// 
    /// </summary>
    public interface ICommandProvider : ICommandProvider<ICommand>
    {
    }
    /// <summary>
    /// 
    /// </summary>
    public interface ICommandProvider<T> : IProvider<T>
    {
    }
}
