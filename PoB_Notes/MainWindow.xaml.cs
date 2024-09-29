using PoB_Notes.View;
using PoB_Notes.MainViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PoB_Notes
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
            Loading();
        }

        private void Loading()
        {
            MainDescription _mainDescription = new MainDescription();
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
