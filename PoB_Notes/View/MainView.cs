using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace PoB_NETRu.View
{
    internal class MainView : INotifyPropertyChanged
    {
        private Color _textDefaultColor = Colors.AliceBlue;

        public Color TextDefaultColor
        {
            get { return _textDefaultColor; }
            set
            {
                if (_textDefaultColor != value)
                {
                    _textDefaultColor = value;
                    OnPropertyChanged();
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
