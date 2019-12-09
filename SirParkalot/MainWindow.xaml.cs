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
using SirParkalot.pages;

namespace SirParkalot
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private SettingsModel SettingsModel { get; }

        public MainWindow()
        {
            InitializeComponent();

            SettingsModel = new SettingsModel();

            DataContext = SettingsModel;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Window.Content = new MainPage(Window);
        }

        private void Window_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Key != Key.R) return;

            Window.Content = new MainPage(Window);
        }

    }
}
