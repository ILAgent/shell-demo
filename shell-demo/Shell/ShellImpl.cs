using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Contracts;
using Shell.ViewModels;

namespace Shell
{
    class ShellImpl: IShell 
    {
        private readonly ModuleLoader _loader;
        private readonly ShellViewModel _shellViewModel;

        public ShellImpl(ModuleLoader loader, ShellViewModel shellViewModel)
        {
            _loader = loader;
            _shellViewModel = shellViewModel;
        }

        public IList<ShellMenuItem> MenuItems { get { return _shellViewModel.MenuItems; } }

        public IModule LoadModule(Assembly assembly)
        {
            return _loader.LoadModule(assembly);
        }
    }
}
