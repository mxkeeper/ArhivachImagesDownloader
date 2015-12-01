﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MahApps.Metro;
using System.Windows;

namespace IBDownloader
{
    public class Options
    {
        private int _MaxConcurrentDownloads = 1;
        private int _MaxConnectionPerServer = 1;
        // Время обновления треда по умолчанию 5 мин
        private int _AutoUpdateInterval = 5;
        private bool _AutoRefresh = false;

        public int MaxConcurrentDownloads
        {
            get { return _MaxConcurrentDownloads; }
            set { _MaxConcurrentDownloads = value; }
        }

        public int MaxConnectionPerServer
        {
            get { return _MaxConnectionPerServer; }
            set { _MaxConnectionPerServer = value; }
        }

        public bool AutoRefresh
        {
            get { return _AutoRefresh; }
            set { _AutoRefresh = value; }
        }

<<<<<<< HEAD
        public int AutoUpdateInterval
        {
            get { return _AutoUpdateInterval; }
            set { _AutoUpdateInterval = value; }
        }

=======
>>>>>>> 7690655da53fb56f09fe451b773294787faa7f55
        public void Save()
        {
            var theme = ThemeManager.DetectAppStyle(Application.Current);

            Properties.Settings.Default["AppTheme"] = theme.Item1.Name;
            Properties.Settings.Default["AppColor"] = theme.Item2.Name;
<<<<<<< HEAD
            Properties.Settings.Default["AutoRefresh"] = AutoRefresh;
            Properties.Settings.Default["AutoUpdateInterval"] = AutoUpdateInterval;
            
=======
>>>>>>> 7690655da53fb56f09fe451b773294787faa7f55
            Properties.Settings.Default.Save();
        }

        public void Load()
        {
            string AppTheme = Properties.Settings.Default["AppTheme"].ToString();
            string AppColor = Properties.Settings.Default["AppColor"].ToString();

            // get the theme from the current application
            var theme = ThemeManager.DetectAppStyle(Application.Current);

            // now set the Green accent and dark theme
            ThemeManager.ChangeAppStyle(Application.Current,
                                        ThemeManager.GetAccent(AppColor),
                                        ThemeManager.GetAppTheme(AppTheme));
<<<<<<< HEAD

            AutoRefresh = Convert.ToBoolean(Properties.Settings.Default["AutoRefresh"].ToString());
            AutoUpdateInterval = Convert.ToInt32(Properties.Settings.Default["AutoUpdateInterval"].ToString());
=======
>>>>>>> 7690655da53fb56f09fe451b773294787faa7f55
        }
    }
}
