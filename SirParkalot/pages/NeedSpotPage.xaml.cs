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
    }
}
