using System.ComponentModel;
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

        public NotesViewModel()
        {
            
        }

        public void ChangeTextColor(object sender, TextSelection selection)
        {
            if (!string.IsNullOrEmpty(selection.Text))
            {
                Button clickedButton = sender as Button;

                if (clickedButton != null)
                {
                    Style buttonStyle = clickedButton.Style;

                    if (buttonStyle != null)
                    {
                        foreach (Setter setter in buttonStyle.Setters)
                        {
                            if (setter.Property == TextElement.ForegroundProperty)
                            {
                                SolidColorBrush colorBrush = setter.Value as SolidColorBrush;

                                if (colorBrush != null)
                                {
                                    TextRange textRange = new TextRange(selection.Start, selection.End);
                                    textRange.ApplyPropertyValue(TextElement.ForegroundProperty, colorBrush);
                                }
                            }
                        }
                    }
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
