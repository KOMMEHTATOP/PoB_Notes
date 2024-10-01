using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace PoB_NETRu.Models
{
    internal class Character : INotifyPropertyChanged
    {

        public Character(string charName, int charLevel = 1)
        {
            CharName = charName;
            CharLevel = charLevel;
            
            Health = 100; 
            EnergyShield = 0; 
            Armour = 0; 
            EvationRating = 0; 
            SpellSuppres = 0; 
            
            Strength = 10; 
            Dexterity = 10; 
            Intelligence = 10; 
            
            PhysicalDamage = 5;
            ElementalDamage = 0; 
            ChaosDamage = 0; 
        }

        private string _charName;
        public string CharName
        {
            get { return _charName; }
            set
            {
                if (_charName != value)
                {
                    _charName = value;
                    OnPropertyChanged();
                }
            }
        }

        private int _charLevel;
        public int CharLevel
        {
            get { return _charLevel; }
            set
            {
                if (_charLevel != value)
                {
                    _charLevel = value;
                    OnPropertyChanged();
                }
            }
        }

        private int _health;
        public int Health
        {
            get { return _health; }
            set
            {
                if (_health != value)
                {
                    _health = value;
                    OnPropertyChanged();
                }
            }
        }

        private int _energyShield;
        public int EnergyShield
        {
            get { return _energyShield; }
            set
            {
                if (_energyShield != value)
                {
                    _energyShield = value;
                    OnPropertyChanged();
                }
            }
        }

        private int _armour;
        public int Armour
        {
            get { return _armour; }
            set
            {
                if (_armour != value)
                {
                    _armour = value;
                    OnPropertyChanged();
                }
            }
        }

        private int _evationRating;
        public int EvationRating
        {
            get { return _evationRating; }
            set
            {
                if (_evationRating != value)
                {
                    _evationRating = value;
                    OnPropertyChanged();
                }
            }
        }

        private int _spellSuppres;
        public int SpellSuppres
        {
            get { return _spellSuppres; }
            set
            {
                if (_spellSuppres != value)
                {
                    _spellSuppres = value;
                    OnPropertyChanged();
                }
            }
        }

        private int _strength;
        public int Strength
        {
            get { return _strength; }
            set
            {
                if (_strength != value)
                {
                    _strength = value;
                    OnPropertyChanged();
                }
            }
        }

        private int _dexterity;
        public int Dexterity
        {
            get { return _dexterity; }
            set
            {
                if (_dexterity != value)
                {
                    _dexterity = value;
                    OnPropertyChanged();
                }
            }
        }

        private int _intelligence;
        public int Intelligence
        {
            get { return _intelligence; }
            set
            {
                if (_intelligence != value)
                {
                    _intelligence = value;
                    OnPropertyChanged();
                }
            }
        }

        private int _physicalDamage;
        public int PhysicalDamage
        {
            get { return _physicalDamage; }
            set
            {
                if (_physicalDamage != value)
                {
                    _physicalDamage = value;
                    OnPropertyChanged();
                }
            }
        }

        private int _elementalDamage;
        public int ElementalDamage
        {
            get { return _elementalDamage; }
            set
            {
                if (_elementalDamage != value)
                {
                    _elementalDamage = value;
                    OnPropertyChanged();
                }
            }
        }

        private int _chaosDamage;
        public int ChaosDamage
        {
            get { return _chaosDamage; }
            set
            {
                if (_chaosDamage != value)
                {
                    _chaosDamage = value;
                    OnPropertyChanged();
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
