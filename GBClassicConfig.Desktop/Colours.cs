using MahApps.Metro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace GBClassicConfig.Desktop
{
    class Colours
    {
        public static void Change(string NewTheme, string NewAccent)
        {
            var CurrentTheme = ThemeManager.DetectAppStyle(Application.Current);
            if (NewTheme == "") // If theme name is not supplied
            {
                NewTheme = CurrentTheme.Item1.Name; // Keep current theme
            }
            else if (NewAccent == "")  // If accent name is not supplied
            {
                NewAccent = CurrentTheme.Item2.Name; // Keep current accent
            }
            ThemeManager.ChangeAppStyle(Application.Current,
                            ThemeManager.GetAccent(NewAccent), // Set accent
                            ThemeManager.GetAppTheme(NewTheme)); // Set theme
        }
    }
}
