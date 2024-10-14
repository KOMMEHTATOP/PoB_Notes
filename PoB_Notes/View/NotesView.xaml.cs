using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Media;

namespace PoB_NETRu.View
{
    public partial class NotesView : UserControl
    {
        public NotesView()
        {
            InitializeComponent();
        }

        private void ChangeTextColor(SolidColorBrush color)
        {
            TextSelection selection = UserInput.Selection;
            if (selection != null && selection.IsEmpty == false)
            {
                selection.ApplyPropertyValue(TextElement.ForegroundProperty, color);
            }
        }
    }
}
