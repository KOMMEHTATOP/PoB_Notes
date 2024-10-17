using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace PoB_NETRu.Models.Tree
{
    public class SkillTree
    {
        public ObservableCollection<Classes> Classes { get; set; } = new ObservableCollection<Classes>();

        public SkillTree()
        {
        }
    }

}
