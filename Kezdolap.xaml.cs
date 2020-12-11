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
using System.Windows.Shapes;

namespace Tesla_autókonfigurátor
{
    /// <summary>
    /// Interaction logic for Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        public Window2()
        {
            InitializeComponent();
        }

        private void Windows_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            Windows.Title = $"{Windows.ActualWidth} x {Windows.ActualHeight}";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            CloseWindow closeWindow = new CloseWindow();
            closeWindow.Show();
        }
    }
}
