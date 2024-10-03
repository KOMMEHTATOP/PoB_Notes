using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace PoB_NETRu.View
{
    internal class NotesDescription : INotifyPropertyChanged
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

        public NotesDescription()
        {

        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged([CallerMemberName] string propertyName =null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
