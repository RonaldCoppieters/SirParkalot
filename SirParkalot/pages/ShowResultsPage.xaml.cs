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
    /// Interaction logic for ShowResultsPage.xaml
    /// </summary>
    public partial class ShowResultsPage : Page
    {
        private MainWindow Window { get; }
        public ShowResultsPage(MainWindow window)
        {
            InitializeComponent();

            Window = window;
        }

        private void BackButton_OnClick(object sender, RoutedEventArgs e)
        {
            Window.Content = new NeedSpotPage(Window);
        }
    }
}
