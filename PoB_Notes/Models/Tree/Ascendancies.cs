

namespace PoB_NETRu.Models.Tree
{
    public class Ascendancies
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string FlavourText { get; set; }
        public string FlavourTextColour { get; set; }
        public FlavourTextRect FlavourTextRect { get; set; }
    }

    public class FlavourTextRect
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
    }

}
