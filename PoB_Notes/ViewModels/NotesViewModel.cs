using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Media;

namespace PoB_NETRu.ViewModels
{
    public class NotesViewModel
    {
        public void ChangeTextColor(object sender, TextSelection selection)
        {
            if (!string.IsNullOrEmpty(selection.Text))
            {
                Button clickedButton = sender as Button;

                if (clickedButton != null)
                {
                    Style buttonStyle = clickedButton.Style;

                    if (buttonStyle != null)
                    {
                        foreach (Setter setter in buttonStyle.Setters)
                        {
                            if (setter.Property == TextElement.ForegroundProperty)
                            {
                                SolidColorBrush colorBrush = setter.Value as SolidColorBrush;

                                if (colorBrush != null)
                                {
                                    TextRange textRange = new TextRange(selection.Start, selection.End);
                                    textRange.ApplyPropertyValue(TextElement.ForegroundProperty, colorBrush);
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
