using PoB_NETRu.MainViewModels;
using System.Windows;

namespace PoB_NETRu
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new MainViewModel(); 
        }
    }
}
