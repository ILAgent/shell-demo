using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using Contracts;
using Microsoft.Win32;

namespace Module.ViewModels
{
    class SecondViewModel
    {
        private readonly IShell _shell;

        public SecondViewModel(IShell shell)
        {
            _shell = shell;
        }

        public void Load()
        {
            var dlg = new OpenFileDialog ();

            if (dlg.ShowDialog().GetValueOrDefault())
            {
                var asm = Assembly.LoadFrom(dlg.FileName);
                var module = _shell.LoadModule(asm);
                if(module!=null)
                    module.Init();
            }
        }
    }
}
