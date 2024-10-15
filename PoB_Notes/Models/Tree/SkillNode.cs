using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoB_NETRu.Models.Tree
{
    public class SkillNode
    {
        public string Name { get; set; }
        public List<SkillNode> Children { get; set; } = new List<SkillNode>();
        public string Tooltip { get; set; }
        public bool IsActive { get; set; }
        public bool IsUnlocked { get; set; } // Новый признак

        public SkillNode(string name, string tooltip)
        {
            Name = name;
            Tooltip = tooltip;
            IsUnlocked = false; // По умолчанию узел заблокирован
        }

        public void AddChild(SkillNode child)
        {
            Children.Add(child);
        }

        public void Unlock()
        {
            IsUnlocked = true;
        }
    }

}

