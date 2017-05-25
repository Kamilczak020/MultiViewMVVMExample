using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight.Command;
using PropertyChanged;
using System.Windows.Input;

namespace Pagination
{
    [ImplementPropertyChanged]
    class MainViewModel : IViewModel
    {
        public ICommand ShowHomeViewCommand { get { return new RelayCommand(setHomeViewModel, () => true); } }
        public ICommand ShowAuditViewCommand { get { return new RelayCommand(setAuditViewModel, () => true); } }

        public IViewModel DisplayViewModel { get; set; }

        public MainViewModel()
        {
            DisplayViewModel = new HomeViewModel();
        }

        private void setHomeViewModel()
        {
            DisplayViewModel = new HomeViewModel();

        }

        private void setAuditViewModel()
        {
            DisplayViewModel = new AuditViewModel();

        }
    }
}
