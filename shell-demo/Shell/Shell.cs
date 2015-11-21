using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Contracts;

namespace Shell
{
    class Shell: IShell 
    {
        public Shell()
        {
            MenuItems = new ObservableCollection<ShellMenuItem>();
        }

        public IList<ShellMenuItem> MenuItems { get; private set; }

        public IModule LoadModule(Assembly assembly)
        {
            throw new NotImplementedException();
        }
    }
}
