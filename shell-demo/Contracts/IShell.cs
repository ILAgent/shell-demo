using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Contracts
{
    public interface IShell
    {
        IList<ShellMenuItem> MenuItems { get; }

        IModule LoadModule(Assembly assembly);
    }
}
