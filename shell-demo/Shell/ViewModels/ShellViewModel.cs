using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Caliburn.Micro;
using Contracts;

namespace Shell.ViewModels
{
    class ShellViewModel: PropertyChangedBase
    {
        public ShellViewModel()
        {
            MenuItems = new ObservableCollection<ShellMenuItem>();
        }

        public ObservableCollection<ShellMenuItem> MenuItems { get; private set; }

        private ShellMenuItem _selectedMenuItem;
        public ShellMenuItem SelectedMenuItem
        {
            get { return _selectedMenuItem; }
            set
            {
                if(_selectedMenuItem==value)
                    return;
                _selectedMenuItem = value;
                NotifyOfPropertyChange(() => SelectedMenuItem);
                NotifyOfPropertyChange(() => CurrentView);
            }
        }

        public object CurrentView
        {
            get { return _selectedMenuItem == null ? null : _selectedMenuItem.ScreenViewModel; }
        }

    }
}
