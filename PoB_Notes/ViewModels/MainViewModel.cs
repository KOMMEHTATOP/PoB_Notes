using PoB_NETRu.Commands;
using PoB_NETRu.Models;
using PoB_NETRu.ViewModels;
using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace PoB_NETRu.MainViewModels
{
    public class MainViewModel : INotifyPropertyChanged
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

        public ICommand ShowNotesCommand { get; }
        public ICommand ShowSkillTreeCommand { get; }

        public MainViewModel()
        {
            Character = new Character("Иван", 1);
            ShowNotesCommand = new RelayCommand(_ => ShowView("Notes"));
            ShowSkillTreeCommand = new RelayCommand(_ => ShowView("Skills"));
            SelectedViewModel = new NotesViewModel();
        }

        private void ShowView(string viewName)
        {
            switch (viewName)
            {
                case "Notes":
                    SelectedViewModel = new NotesViewModel();
                    break;
                case "Skills":
                    SelectedViewModel = new TreeSkillsViewModel(Character); // Передаем персонажа
                    break;
            }
        }


        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
