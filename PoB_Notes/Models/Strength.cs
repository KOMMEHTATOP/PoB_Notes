using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;

namespace PoB_NETRu.DataBase
{
    internal class Strength : INotifyPropertyChanged
    {
        private Color _strengthColor = (Color)ColorConverter.ConvertFromString("#E05030");
        public Color StrengthColor
        {
            get { return _strengthColor; }
            set
            {
                if (_strengthColor != value)
                {
                    _strengthColor = value;
                    OnPropertyChanged();
                }
            }
        }

        private double _lifeUp;
        public double LifeUp
        {
            get { return _lifeUp; }
            set
            {
                if (_lifeUp != value)
                {
                    _lifeUp = value;
                    OnPropertyChanged();
                }
            }
        }
        private double _damageUp;
        public double DamageUp
        {
            get { return _damageUp; }
            set
            {
                if (_damageUp != value)
                {
                    _damageUp = value;
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
