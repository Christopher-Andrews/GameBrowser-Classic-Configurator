using MahApps.Metro.Controls;
using MahApps.Metro.Controls.Dialogs;
using System;
using System.Globalization;
using System.Reflection;
using System.Windows;

namespace GBClassicConfig.Desktop
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {


        public MainWindow()
        {
            #region - Get version number...
            Version v = Assembly.GetExecutingAssembly().GetName().Version; // Find version number
            string Build_Number = string.Format(CultureInfo.InvariantCulture, @"V{0}.{1}.{2} (r{3})", v.Major, v.Minor, v.Build, v.Revision); // Format version number
            Properties.Settings.Default.Version_Number = Build_Number; // Push version number to settings
            Properties.Settings.Default.Save(); // Save settings
            #endregion

            InitializeComponent();

            Colours.Change(Properties.Settings.Default.Theme, Properties.Settings.Default.Accent); // Set theme and accent to last used
       
        }


        #region - Open / close flyout...
        public void ToggleFlyout(int index)
        {
            var flyout = this.Flyouts.Items[index] as Flyout;
            if (flyout == null)
            {
                return;
            }

            flyout.IsOpen = !flyout.IsOpen;
        }
        #endregion

        #region - Settings button clicked...
        private void SettingsButton_Click(object sender, RoutedEventArgs e)
        {
            ToggleFlyout(1); // Open flyout
        }
        #endregion

        #region - Help button clicked...


        internal void HelpButton_Click(object sender, RoutedEventArgs e)
        {
            OpenFlyout(1);
        }
        #endregion

        private void VersionStatus_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
        {
            OpenFlyout(0); // Open flyout
        }


        public void OpenFlyout(int flyout)
        {
            ToggleFlyout(flyout);
        }

    }
}
