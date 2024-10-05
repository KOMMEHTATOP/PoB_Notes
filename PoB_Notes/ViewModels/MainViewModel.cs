using PoB_NETRu.Models;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace PoB_NETRu.MainViewModels
{
    internal class MainViewModel : INotifyPropertyChanged
    {
        private Character _character;

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

        public MainViewModel()
        {
            Character = new Character("Иван", 1);
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
