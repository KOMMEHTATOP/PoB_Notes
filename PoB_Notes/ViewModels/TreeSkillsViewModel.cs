using PoB_NETRu.Models;
using PoB_NETRu.Models.Tree;
using System.Collections.ObjectModel;
using System.Diagnostics;

namespace PoB_NETRu.ViewModels
{
    public class TreeSkillsViewModel
    {
        public ObservableCollection<ClassAscendancy> ClassAscendancies { get; private set; }

        public TreeSkillsViewModel(Character character, ObservableCollection<ClassAscendancy> classAscendancies)
        {
            ClassAscendancies = classAscendancies;

            foreach (var cls in classAscendancies)
            {
                Debug.WriteLine($"Class: {cls.ClassName}, BaseStr: {cls.BaseStr}, BaseDex: {cls.BaseDex}, BaseInt: {cls.BaseInt}");

            }
        }
    }
}
