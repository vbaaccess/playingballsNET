﻿using System;
using System.Collections.Generic;
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

namespace WpfPlayingBalls
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            MessageBoxResult MBR = MessageBoxResult.Yes;
            MBR = MessageBox.Show("Czy napewno chcesz zamknąć program ?", "UWAGA", MessageBoxButton.YesNo, MessageBoxImage.Question);

            //if (MBR == MessageBoxResult.Yes)
            //    Application.Current.Shutdown();

            if (MBR == MessageBoxResult.No)
                e.Cancel = true;
        }
    }
}
