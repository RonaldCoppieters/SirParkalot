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
    /// Interaction logic for MainPage.xaml
    /// </summary>
    public partial class MainPage : Page
    {
        private MainWindow Window { get; }

        public MainPage(MainWindow window)
        {
            InitializeComponent();
            Window = window;
        }

        private void SettingsBorder_MouseUp(object sender, MouseButtonEventArgs e)
        { 
            Window.Content = new SettingsPage(Window);
        }

        private void NeedSpotButton_OnClick(object sender, RoutedEventArgs e)
        {
            Window.Content = new NeedSpotPage(Window);
        }

        private void HaveSpotButton_OnClick(object sender, RoutedEventArgs e)
        {
            Window.Content = new RegisterPage(Window);
        }
    }
}
