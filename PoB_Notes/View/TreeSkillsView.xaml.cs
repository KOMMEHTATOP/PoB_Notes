using PoB_NETRu.Models;
using PoB_NETRu.Models.Tree;
using PoB_NETRu.ViewModels;
using System.Collections.ObjectModel;
using System.Windows.Controls;

namespace PoB_NETRu.View
{
    public partial class TreeSkillsView : UserControl
    {
        public TreeSkillsView()
        {
            InitializeComponent();

            // Парсинг JSON и заполнение коллекции ClassAscendancy
            var parser = new SkillTreeParser();
            ObservableCollection<ClassAscendancy> classAscendancies = parser.ParseSkillTree(@"Models\Tree\data.json");

            // Инициализация ViewModel с заполненными данными
            var viewModel = new TreeSkillsViewModel(new Character(), classAscendancies);

            // Установка DataContext
            this.DataContext = viewModel;
        }
    }
}
