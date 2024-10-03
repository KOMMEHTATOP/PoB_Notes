using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Media;


namespace PoB_NETRu.View
{
    public partial class NotesView : Window
    {
        public NotesView()
        {
            InitializeComponent();
            
            Loading();
        }

        private void Loading()
        {
            NotesDescription _mainDescription = new NotesDescription();
            this.DataContext = _mainDescription;

            NormalButton.Click += ChengeTextColor;
            FireButton.Click += ChengeTextColor;
            StrenghtButton.Click += ChengeTextColor;
            MagicButton.Click += ChengeTextColor;
            ColdButton.Click += ChengeTextColor;
            DexterityButton.Click += ChengeTextColor;
            RareButton.Click += ChengeTextColor;
            LightningButton.Click += ChengeTextColor;
            IntelligenceButton.Click += ChengeTextColor;
            UniqueButton.Click += ChengeTextColor;
            ChaosButton.Click += ChengeTextColor;
            StandartButton.Click += ChengeTextColor;
        }

        private void ChengeTextColor(object sender, RoutedEventArgs e)
        {
            TextSelection selection = UserInput.Selection;
            string selectionText = selection.Text;

            if (!string.IsNullOrEmpty(selectionText))
            {

                Button clickedButton = sender as Button;

                if (clickedButton!=null)
                {
                    TextSelection selections = UserInput.Selection;
                    string selectionTexts = selection.Text;

                    if (!string.IsNullOrEmpty(selectionTexts))
                    {
                        TextRange textRange = new TextRange(selection.Start, selection.End);
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
}
