using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SirParkalot.pages
{
    /// <summary>
    /// Interaction logic for NeedSpotPage.xaml
    /// </summary>
    public partial class NeedSpotPage : Page
    {

        private MainWindow Window { get; }
        public NeedSpotPage(MainWindow window)
        {
            InitializeComponent();

            Window = window;
        }

        private void SettingsButton_OnClick(object sender, RoutedEventArgs e)
        {
            Window.Content = new SettingsPage(Window);
        }

        private void SpotFinderButton_OnClick(object sender, RoutedEventArgs e)
        {
            Window.Content = new ShowResultsPage(Window);
        }
        
        private void BackButton_OnClick(object sender, RoutedEventArgs e)
        {
            Window.Content = new MainPage(Window);
        }

        private void LocationButton_OnMouseEnter(object sender, MouseEventArgs e)
        {
            if (e.Handled) return;

            var source = e.Source;

            if (!(source is Border)) return;

            var border = (Border) source;

            border.Background = new SolidColorBrush(Color.FromRgb(42, 69, 116));
            e.Handled = true;
        }

        private void LocationButton_OnMouseLeave(object sender, MouseEventArgs e)
        {
            if (e.Handled) return;

            var source = e.Source;

            if (!(source is Border)) return;

            var border = (Border)source;

            border.Background = new SolidColorBrush(Color.FromRgb(135, 206, 250));
            e.Handled = true;
        }
    }
}
