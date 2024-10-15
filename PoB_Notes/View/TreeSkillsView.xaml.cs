using PoB_NETRu.Models;
using PoB_NETRu.Models.Tree;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Shapes;

namespace PoB_NETRu.View
{
    public partial class TreeSkillsView : UserControl
    {
        public Character Character { get; set; }  // Свойство для модели персонажа

        // Публичный параметрless конструктор
        public TreeSkillsView()
        {
            InitializeComponent();
            Loaded += TreeSkillsView_Loaded; // Подписка на событие загрузки
        }

        // Конструктор, который принимает объект персонажа
        public TreeSkillsView(Character character) : this() // Вызов параметрless конструктора
        {
            Character = character; // Присваиваем переданный объект персонажа
        }

        private void TreeSkillsView_Loaded(object sender, RoutedEventArgs e)
        {
            DrawLines();
        }

        private void DrawLines()
        {
            // Здесь будет логика рисования линий между узлами
            var canvas = (Canvas)Content; // Получаем доступ к Canvas

            // Пример: добавление линии между двумя узлами
            Line line = new Line
            {
                X1 = 125, // Начальная точка X
                Y1 = 125, // Начальная точка Y
                X2 = 200, // Конечная точка X
                Y2 = 225, // Конечная точка Y
                Stroke = Brushes.Black, // Цвет линии
                StrokeThickness = 2 // Толщина линии
            };
            canvas.Children.Add(line); // Добавляем линию на Canvas
        }

        private void SkillNode_MouseDown(object sender, MouseButtonEventArgs e)
        {
            var clickedNode = sender as Ellipse;

            if (clickedNode != null)
            {
                var contextMenu = (ContextMenu)FindResource("SkillNodeContextMenu");
                contextMenu.PlacementTarget = clickedNode;
                contextMenu.IsOpen = true;
            }
        }

    }
}
