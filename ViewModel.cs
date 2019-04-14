using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WpfApp3
{

    public class ViewModel : ViewModelBase
    {
        private readonly DelegateCommand _changeNameCommand;
        public ICommand ChangeNameCommand => _changeNameCommand;
        private string _firstName;

        public ViewModel()
        {
            _changeNameCommand = new DelegateCommand(OnChangeName);
        }

        public string FirstName
        {
            get => _firstName;
            set => SetProperty(ref _firstName, value);
        }

        private void OnChangeName(object commandParameter)
        {
            FirstName = "Reut";
        }
    }
    
}
