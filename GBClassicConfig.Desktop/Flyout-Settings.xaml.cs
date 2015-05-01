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
    public partial class SettingsFlyout : Flyout, INotifyPropertyChanged
    {
        # region Only here so build is happy...
        public event PropertyChangedEventHandler PropertyChanged;
        #endregion

        # region - Declarations...
        public string[] Themes = new string[] { "BaseLight", "BaseDark" };
        public string[] Accents = new string[] { "Amber", "Blue", "Brown", "Cobalt", "Crimson", "Cyan", "Emerald", "Green", "Indigo", "Lime", "Magenta", "Mauve", "Olive", "Orange", "Pink", "Purple", "Red", "Sienna", "Steel", "Taupe", "Teal", "Violet", "Yellow" };
        public int SelectedItem;
        #endregion

        public SettingsFlyout()
        {
            InitializeComponent();
            VersionText.Text = GBClassicConfig.Desktop.Properties.Settings.Default.Version_Number + " (" + GBClassicConfig.Desktop.Properties.Settings.Default.Version_Name + ")";
            ToastToggle.IsChecked = Properties.Settings.Default.Toast_Enabled; // Read toast preference from settings and set toggle switch accordingly - default is on (True)
        }

        #region - User clicks an accent...
        private void AccentTile_Click(object sender, RoutedEventArgs e)
        {
            Colours.Change("", Accents[Convert.ToInt32(((Control)sender).Uid)]); // Keep theme, use tile uid as reference to find accent in accent array and set accent
            Properties.Settings.Default.Accent = Accents[Convert.ToInt32(((Control)sender).Uid)]; // Push new accent to settings
            Properties.Settings.Default.Save(); // Save settings
        }
        #endregion

        #region - User clicks a theme...
        private void ThemeTile_Click(object sender, RoutedEventArgs e)
        {
            Colours.Change(Themes[Convert.ToInt32(((Control)sender).Uid)], ""); // Keep accent, use tile uid as reference for to find theme in theme array and set theme
            Properties.Settings.Default.Theme = Themes[Convert.ToInt32(((Control)sender).Uid)]; // Push theme to settings
            Properties.Settings.Default.Save(); // Save settings
        }
        #endregion

        #region - User toggles toast switch
        private void ToastToggle_Checked(object sender, RoutedEventArgs e)
        {
            Properties.Settings.Default.Toast_Enabled = true; // Set toasts to on (True)
            Properties.Settings.Default.Save(); // Save settings
        }
        #endregion

        #region - Toast toggle switch state has changed...
        private void ToastToggle_IsCheckedChanged(object sender, EventArgs e)
        {
            if (ToastToggle.IsChecked == true) // Check if user has enabled toasts
            {
                Properties.Settings.Default.Toast_Enabled = true; // Toasts are on (True)
                Properties.Settings.Default.Save(); // Save settings
                Debug.Print("Toasts enabled"); // Print debug message
            }
            else
            {
                Properties.Settings.Default.Toast_Enabled = false; // Toasts are off (False)
                Properties.Settings.Default.Save(); // Save settings
                Debug.Print("Toasts disabled"); // Print debug message
            }
        }
        #endregion




    }
}
