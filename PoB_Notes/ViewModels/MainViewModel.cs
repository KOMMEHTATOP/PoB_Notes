using PoB_NETRu.Commands;
using PoB_NETRu.Models;
using PoB_NETRu.ViewModels;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace PoB_NETRu.MainViewModels
{
    internal class MainViewModel : INotifyPropertyChanged
    {
        private Character _character;
        private object _selectedViewModel;
        public ICommand SwitchViewCommand { get; }

        public Character Character
        {
            get { return _character; }
            set
            {
                if (_character != value)
                {
                    _character = value;
                    OnPropertyChanged();
                }
            }
        }
        public object SelectedViewModel
        {
            get { return _selectedViewModel; }
            set 
            {
                _selectedViewModel = value;
                OnPropertyChanged(nameof(SelectedViewModel));
            }
        }


        public MainViewModel()
        {
            Character = new Character("Иван", 1);
            SwitchViewCommand = new RelayCommand(SwitchView);
            SelectedViewModel = new NotesViewModel();
        }

        private void SwitchView(object parametr)
        {
            if (parametr is string viewName)
            {
                switch (viewName)
                {
                    case "Notes":
                        SelectedViewModel = new NotesViewModel();
                        break;
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
