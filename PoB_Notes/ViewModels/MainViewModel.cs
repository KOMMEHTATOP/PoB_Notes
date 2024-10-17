using PoB_NETRu.Commands;
using PoB_NETRu.Models;
using PoB_NETRu.Models.Tree;
using PoB_NETRu.ViewModels;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace PoB_NETRu.MainViewModels
{
    public class MainViewModel : INotifyPropertyChanged
    {
        private Character _character;
        private object _selectedViewModel;

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

        public ICommand SwitchViewCommand { get; }
        public ICommand ShowNotesCommand { get; }
        public ICommand ShowSkillTreeCommand { get; }

        // Инициализация коллекции
        public ObservableCollection<Classes> Classes { get; } = new ObservableCollection<Classes>();

        public MainViewModel()
        {
            SkillTreeParser parser = new SkillTreeParser();
            Character = new Character("Иван", 1);

            ShowNotesCommand = new RelayCommand(_ => ShowView("Notes"));
            ShowSkillTreeCommand = new RelayCommand(_ => ShowView("Skills"));

            SelectedViewModel = new NotesViewModel();

            // Полный путь к файлу
            string filePath = @"Models\Tree\data.json";
            // Парсинг JSON файла
            ObservableCollection<ClassAscendancy> classAscendancies = parser.ParseSkillTree(filePath);

            // Передаем загруженное дерево умений
            ShowView("Skills", classAscendancies);
        }

        private void ShowView(string viewName, ObservableCollection<ClassAscendancy> classAscendancies = null)
        {
            switch (viewName)
            {
                case "Notes":
                    SelectedViewModel = new NotesViewModel();
                    break;
                case "Skills":
                    // Передаем персонажа и коллекцию ClassAscendancy
                    SelectedViewModel = new TreeSkillsViewModel(Character, classAscendancies);
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
