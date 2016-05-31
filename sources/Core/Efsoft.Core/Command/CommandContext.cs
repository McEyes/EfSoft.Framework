using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Efsoft.Core.Command
{
    public class CommandContext : IProviderContext<CommandContext>
    {
        public CommandContext Current
        {
            get { return this; }
        }
    }
}
