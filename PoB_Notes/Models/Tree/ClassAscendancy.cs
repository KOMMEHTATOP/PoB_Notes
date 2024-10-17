using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoB_NETRu.Models.Tree
{
    public class ClassAscendancy
    {
        public string ClassName { get; set; }
        public int BaseStr { get; set; }
        public int BaseDex { get; set; }
        public int BaseInt { get; set; }
        public string AscendancyName { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public string FlavourText { get; set; }
    }
}
