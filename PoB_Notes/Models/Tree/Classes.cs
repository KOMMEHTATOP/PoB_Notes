using System.Collections.ObjectModel;

namespace PoB_NETRu.Models.Tree
{
    public class Classes
    {
        public string Name { get; set; }
        public int Base_Str { get; set; }
        public int Base_Dex { get; set; }
        public int Base_Int { get; set; }
        public ObservableCollection<Ascendancies> Ascendancies { get; set; } = new ObservableCollection<Ascendancies>();
        public Ascendancies Ascendancy1 { get; set; }
        public Ascendancies Ascendancy2 { get; set; }
        public Ascendancies Ascendancy3 { get; set; }
    }
}
