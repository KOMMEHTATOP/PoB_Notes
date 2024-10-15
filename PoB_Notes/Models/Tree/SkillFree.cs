using System.Collections.Generic;

namespace PoB_NETRu.Models.Tree
{
    public class SkillTree
    {
        public SkillNode Root { get; private set; }

        public SkillTree()
        {
            // Создаем корневой узел
            Root = new SkillNode("Варвар", "Основной класс");

            // Создаем дочерние узлы
            var strengthNode = new SkillNode("Сила", "Увеличивает силу");
            var intelligenceNode = new SkillNode("Интеллект", "Увеличивает интеллект");
            var healthNode = new SkillNode("Здоровье", "Увеличивает здоровье");

            // Добавляем дочерние узлы к корневому
            Root.AddChild(strengthNode);
            Root.AddChild(intelligenceNode);
            Root.AddChild(healthNode);
        }
    }
}
