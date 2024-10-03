using PoB_NETRu.View;
using PoB_NETRu.ViewModels;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Media;

namespace PoB_NETRu
{
    public partial class MainWindow : Window
    {
        private NotesViewModel _notesViewModel;

        public MainWindow()
        {
            InitializeComponent();
            
            Loading();
        }

        private void Loading()
        {
            MainDescription _mainDescription = new MainDescription();
            this.DataContext = _mainDescription;

            _notesViewModel = new NotesViewModel();

            NormalButton.Click += ChengeTextColor;
            FireButton.Click += ChengeTextColor;
            StrenghtButton.Click += ChengeTextColor;
            MagicButton.Click += ChengeTextColor;
            ColdButton.Click += ChengeTextColor;
            DexterityButton.Click += ChengeTextColor;
            RareButton.Click += ChengeTextColor;
            LightningButton.Click += ChengeTextColor;
            IntelligenceButton.Click += ChengeTextColor;
            UniqueButton.Click += ChengeTextColor;
            ChaosButton.Click += ChengeTextColor;
            StandartButton.Click += ChengeTextColor;
        }

        private void ChengeTextColor(object sender, RoutedEventArgs e)
        {
            TextSelection selection = UserInput.Selection;
            _notesViewModel.ChangeTextColor(sender, selection);
        }
    }
}
