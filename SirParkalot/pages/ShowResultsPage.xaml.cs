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

        private void ShowResultsPage_OnLoaded(object sender, RoutedEventArgs e)
        {
            foreach (var child in ResultGrid.Children)
            {
                if (!(child is DockPanel)) continue;

                var dockPanel = (DockPanel) child;

                foreach (var child2 in dockPanel.Children)
                {
                    if (!(child2 is Border)) continue;

                    var border = (Border)child2;

                    border.MouseEnter += (o, args) =>
                    {
                        if (args.Handled) return;
                        if (args.Source is Border source) source.BorderBrush = new SolidColorBrush(Color.FromRgb(184, 134, 11));
                        args.Handled = true;
                    };

                    border.MouseLeave += (o, args) =>
                    {
                        if (args.Handled) return;
                        if (args.Source is Border source) source.BorderBrush = new SolidColorBrush(Color.FromRgb(218, 165, 32));
                        args.Handled = true;
                    };
                }
            }
        }
    }
}
