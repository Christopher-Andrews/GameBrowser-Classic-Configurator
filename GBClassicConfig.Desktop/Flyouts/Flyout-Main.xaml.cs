using MahApps.Metro;
using MahApps.Metro.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
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

namespace GBClassicConfig.Desktop
{
    /// <summary>
    /// Interaction logic for Flyout_Settings.xaml
    /// </summary>
    public partial class MainFlyout : Flyout, INotifyPropertyChanged
    {
        # region Only here so build is happy...
        public event PropertyChangedEventHandler PropertyChanged;
        #endregion


        public MainFlyout()
        {
            InitializeComponent();

        }

        private void MenuOption_MouseEnter(object sender, MouseEventArgs e)
        {
            var textblock = sender as TextBlock;
            var converter = new System.Windows.Media.BrushConverter();
            textblock.Background = (Brush)converter.ConvertFromString("#404040");
        }

        private void MenuOption_MouseLeave(object sender, MouseEventArgs e)
        {
            var textblock = sender as TextBlock;
            textblock.Background.Opacity = 0;
        }

        private void OptionsText_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            var MainWindow = new MainWindow();
            MainWindow.HelpButton_Click(sender, e);
        }

        private void HelpText_MouseDown(object sender, MouseButtonEventArgs e)
        {
            
            System.Diagnostics.Process.Start("http://google.com");
        }

        private void OptionsText_MouseDown(object sender, MouseButtonEventArgs e)
        {
            MainWindow of = new MainWindow();
            of.OpenFlyout(2);
            of.Show();
        }


    }
}
