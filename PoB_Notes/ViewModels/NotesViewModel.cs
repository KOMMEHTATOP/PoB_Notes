using PoB_NETRu.Commands;
using PoB_NETRu.View;
using System;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Media;

namespace PoB_NETRu.ViewModels
{
    public class NotesViewModel : INotifyPropertyChanged
    {
        private string _descriptionText =
            $"Вы можете использовать комбинацию клавиш Ctrl +/- для увеличения/уменьшения размера текста.\n" +
            $"Текстовые поля поддерживают подсветку кнопками ниже." +
            $"Используйте их для описания, это поможет легче читать ваши заметки.";

        public string DescriptionText
        {
            get { return _descriptionText; }
            set
            {
                if (_descriptionText != value)
                {
                    _descriptionText = value;
                    OnPropertyChanged();
                }
            }
        }

        public RelayCommand ChangeTextColorCommand { get; private set; }

        public NotesViewModel()
        {
            ChangeTextColorCommand = new RelayCommand(ExecuteChangeColor);
        }

        private void ExecuteChangeColor(object parameter)
        {
            if (parameter is string styleKey)
            {
                var mainWindow = Application.Current.MainWindow;
                var notesView = FindVisualChild<NotesView>(mainWindow);

                if (notesView == null)
                {
                    MessageBox.Show("NotesView не найден. Проверьте путь.");
                    return;
                }

                var richTextBox = FindVisualChild<RichTextBox>(notesView);
                var selection = richTextBox?.Selection;

                if (selection != null && selection.Text.Length > 0)
                {
                    var style = notesView.FindResource(styleKey) as Style;

                    if (style != null)
                    {
                        var colorBrush = style.Setters
                            .OfType<Setter>()
                            .FirstOrDefault(s => s.Property == TextElement.ForegroundProperty)?
                            .Value as SolidColorBrush;

                        if (colorBrush != null)
                        {
                            TextRange textRange = new TextRange(selection.Start, selection.End);
                            textRange.ApplyPropertyValue(TextElement.ForegroundProperty, colorBrush);
                        }
                    }
                }
            }
        }


        public static T FindVisualChild<T>(DependencyObject obj) where T : DependencyObject
        {
            for (int i = 0; i < VisualTreeHelper.GetChildrenCount(obj); i++)
            {
                DependencyObject child = VisualTreeHelper.GetChild(obj, i);
                if (child != null && child is T)
                    return (T)child;
                else
                {
                    T childOfChild = FindVisualChild<T>(child);
                    if (childOfChild != null)
                        return childOfChild;
                }
            }
            return null;
        }




        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
