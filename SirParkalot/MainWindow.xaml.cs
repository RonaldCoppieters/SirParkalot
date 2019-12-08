using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
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
using SirParkalot.Annotations;

namespace SirParkalot
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private UIElement[] _startScreen;

        private SettingsModel SettingsModel { get; set; }

        public MainWindow()
        {
            InitializeComponent();

            SettingsModel = new SettingsModel();

            DataContext = SettingsModel;
        }

        private void FindSpotBorder_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            MainPanel.Children.Clear();

            Uri uri = new Uri(@"C:\Users\rcopp\source\repos\SirParkalot\SirParkalot\resources\PXL_Parking_5_3x.wmv");
            var video = new MediaElement()
            {
                Source = uri,
                LoadedBehavior = MediaState.Play
            };

            MainPanel.Children.Add(video);
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            _startScreen = new UIElement[MainPanel.Children.Count];
            MainPanel.Children.CopyTo(_startScreen, 0);
        }

        private void Window_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Key != Key.R) return;

            MainPanel.Children.Clear();

            foreach (var child in _startScreen)
            {
                MainPanel.Children.Add(child);
            }

            MainPanel.Visibility = Visibility.Visible;
            SettingsPanel.Visibility = Visibility.Hidden;
        }

        private void SettingsBorder_MouseUp(object sender, MouseButtonEventArgs e)
        {
            MainPanel.Visibility = Visibility.Hidden;
            SettingsPanel.Visibility = Visibility.Visible;
        }

    }
}
