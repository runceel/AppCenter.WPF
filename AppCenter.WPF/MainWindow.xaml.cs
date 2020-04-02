﻿using Microsoft.AppCenter.Analytics;
using System;
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

namespace AppCenter.WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void NotImplementedButton_Click(object sender, RoutedEventArgs e)
        {
            if (!(sender is Button b))
            {
                return;
            }

            Analytics.TrackEvent("WindowOpen", new Dictionary<string, string>
            {
                ["WindowName"] = (string)b.Content,
            });

            MessageBox.Show($"{b.Content} 画面を開きました");
        }

        private void CrushButton_Click(object sender, RoutedEventArgs e)
        {
            throw new InvalidOperationException("Crush event for demo");
        }
    }
}
