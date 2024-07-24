using PoB_Notes.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PoB_Notes
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Loading();
        }

        private void Loading()
        {
            MainDescription _mainDescription = new MainDescription() 
            { DescriptionText = 
            $"Вы можете использовать комбинацию клавиш Ctrl +/- для увеличения/уменьшения размера текста.\n" +
            $"Текстовые поля поддерживают подсветку кнопками ниже." +
            $"Используйте их для описания, это поможет легче читать ваши заметки." };
            this.DataContext = _mainDescription;

        }
    }
}
