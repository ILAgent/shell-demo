using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using Contracts;
using Module.ViewModels;

namespace Module
{
    class ModuleImpl : IModule
    {
        private readonly IShell _shell;
        private readonly FirstViewModel _firstViewModel;

        public ModuleImpl(IShell shell, FirstViewModel firstViewModel)
        {
            _shell = shell;
            _firstViewModel = firstViewModel;
        }

        public void Init()
        {
            _shell.MenuItems.Add(new ShellMenuItem() {Caption = "First", ScreenViewModel = _firstViewModel});
        }
    }
}
