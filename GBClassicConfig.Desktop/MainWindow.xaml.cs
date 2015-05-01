using MahApps.Metro.Controls;
using System;
using System.Globalization;
using System.Reflection;

namespace GBClassicConfig.Desktop
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        public MainWindow()
        {
            #region Get version number...
            Version v = Assembly.GetExecutingAssembly().GetName().Version; // Find version number
            string Build_Number = string.Format(CultureInfo.InvariantCulture, @"V{0}.{1}.{2} (r{3})", v.Major, v.Minor, v.Build, v.Revision); // Format version number
            Properties.Settings.Default.Version_Number = Build_Number; // Push version number to settings
            Properties.Settings.Default.Save(); // Save settings
            #endregion

            InitializeComponent();

            VersionStatus.Content = Properties.Settings.Default.Version_Number; // Add version number to status bar
            Colours.Change(Properties.Settings.Default.Theme, Properties.Settings.Default.Accent); // Set theme and accent to last used
       
        }
    }
}
