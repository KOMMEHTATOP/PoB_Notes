using PoB_NETRu.Commands;
using PoB_NETRu.Models;
using PoB_NETRu.Models.Tree;
using System.Windows;
using System.Windows.Input;

namespace PoB_NETRu.ViewModels
{
    public class TreeSkillsViewModel
    {
        public Character Character { get; set; }
        public SkillTree SkillTree { get; private set; }

        public ICommand StrengthCommand { get; }
        public ICommand DexterityCommand { get; }
        public ICommand IntelligenceCommand { get; }

        public TreeSkillsViewModel(Character character, SkillTree skillTree)
        {
            Character = character;
            SkillTree = skillTree; // Сохраняем дерево умений

            StrengthCommand = new RelayCommand(_ => StrengthMenuItem_Click(null, null));
            DexterityCommand = new RelayCommand(_ => DexterityMenuItem_Click(null, null));
            IntelligenceCommand = new RelayCommand(_ => IntelligenceMenuItem_Click(null, null));
        }

        public void StrengthMenuItem_Click(object sender, RoutedEventArgs e)
        {
            if (Character != null)
            {
                Character.Strength += 10;
                MessageBox.Show($"Сила увеличена до: {Character.Strength}");
            }
        }

        public void DexterityMenuItem_Click(object sender, RoutedEventArgs e)
        {
            if (Character != null)
            {
                Character.Dexterity += 10;
                MessageBox.Show($"Ловкость увеличена до: {Character.Dexterity}");
            }
        }

        public void IntelligenceMenuItem_Click(object sender, RoutedEventArgs e)
        {
            if (Character != null)
            {
                Character.Intelligence += 10;
                MessageBox.Show($"Интеллект увеличен до: {Character.Intelligence}");
            }
        }
    }
}
