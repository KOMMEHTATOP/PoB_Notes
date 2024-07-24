using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace PoB_Notes.DataBase
{
    internal class Strength
    {
        public Color StrengthColor { get; set; }
        public int StrengthLevel { get; set; }
        public double LifeUp { get; set; }
        public double DamageUp { get; set; }
        public string StrengthView { get; set; }
    }
}
