using PoB_Notes.Commands;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows.Media;

namespace PoB_Notes.MainViewModels
{
    internal class MainViewModel : INotifyPropertyChanged
    {
        private SolidColorBrush _textColor;

        public SolidColorBrush MyProperty
        {
            get { return _textColor; }
            set 
            { 
                _textColor = value;
                OnPropertyChanged();
            }
        }


        public ICommand MyCommand { get; }
        public MainViewModel()
        {
            MyCommand = new RelayCommand(ExecuteMyCommand);
        }

        private void ExecuteMyCommand()
        {

        }


        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
