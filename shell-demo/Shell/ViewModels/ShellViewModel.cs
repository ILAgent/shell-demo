using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contracts;

namespace Shell.ViewModels
{
    class ShellViewModel
    {
        public ShellViewModel()
        {
            MenuItems = new ObservableCollection<ShellMenuItem>();
        }

        public ObservableCollection<ShellMenuItem> MenuItems { get; private set; }
    }
}
